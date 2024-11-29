using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.WebApi;
using SmartHub.WebApi.Filters;

namespace SmartHub.Webapi.Test.FilterTests;
[TestClass]
public class AuthenticationFilterTests
{
    private Mock<ISessionsService>? _mockSessionService;
    private AuthorizationFilterContext? _context;
    private AuthenticationFilterAttribute? _filter;

    [TestInitialize]
    public void Setup()
    {
        _mockSessionService = new Mock<ISessionsService>();

        var httpContext = new DefaultHttpContext();

        var routeData = new RouteData();

        var actionDescriptor = new ActionDescriptor();

        var actionContext = new ActionContext
        {
            HttpContext = httpContext,
            RouteData = routeData,
            ActionDescriptor = actionDescriptor
        };

        _context = new AuthorizationFilterContext(actionContext, []);

        _filter = new AuthenticationFilterAttribute();

        httpContext.RequestServices = new ServiceCollection()
            .AddSingleton(_mockSessionService.Object)
            .BuildServiceProvider();
    }

    [TestMethod]
    public void ShouldReturnUnauthorizedWhenAuthorizationHeaderIsMissing()
    {
        _filter!.OnAuthorization(_context!);

        var result = _context!.Result as ObjectResult;
        Assert.IsNotNull(result, "Result should not be null");
        Assert.AreEqual((int)HttpStatusCode.Unauthorized, result!.StatusCode);

        Assert.IsNotNull(result.Value, "Result value should not be null");

        var resultString = result.Value!.ToString();
        StringAssert.Contains(resultString, "Unauthenticated");
        StringAssert.Contains(resultString, "You are not authenticated");
    }

    [TestMethod]
    public void ShouldReturnUnauthorizedWhenAuthorizationFormatIsInvalid()
    {
        _context!.HttpContext.Request.Headers[HeaderNames.Authorization] = "invalid_token";

        _filter!.OnAuthorization(_context!);

        var result = _context!.Result as ObjectResult;
        Assert.IsNotNull(result, "Result should not be null");
        Assert.AreEqual((int)HttpStatusCode.Unauthorized, result!.StatusCode);

        Assert.IsNotNull(result.Value, "Result value should not be null");

        var resultString = result.Value!.ToString();
        StringAssert.Contains(resultString, "InvalidAuthorization");
        StringAssert.Contains(resultString, "The provided authorization header format is invalid");
    }

    [TestMethod]
    public void ShouldReturnUnauthorizedWhenAuthorizationIsExpired()
    {
        _context.HttpContext.Request.Headers[HeaderNames.Authorization] = Guid.NewGuid().ToString();
        _mockSessionService.Setup(s => s.ExpiredSession(It.IsAny<string>())).Returns(true);

        _filter.OnAuthorization(_context);

        var result = _context.Result as ObjectResult;
        Assert.IsNotNull(result, "Result should not be null");
        Assert.AreEqual((int)HttpStatusCode.Unauthorized, result.StatusCode);

        Assert.IsNotNull(result.Value, "Result value should not be null");

        var resultString = result.Value.ToString();
        StringAssert.Contains(resultString, "ExpiredAuthorization");
        StringAssert.Contains(resultString, "The provided authorization header is expired");
    }

    [TestMethod]
    public void ShouldSetUserInHttpContextWhenAuthorizationIsValid()
    {
        var token = Guid.NewGuid().ToString();
        var user = new User { Id = Guid.NewGuid(), Name = "Test User" };
        _context.HttpContext.Request.Headers[HeaderNames.Authorization] = token;
        _mockSessionService.Setup(s => s.ExpiredSession(It.IsAny<string>())).Returns(false);
        _mockSessionService.Setup(s => s.GetUserByToken(token)).Returns(user);

        _filter.OnAuthorization(_context);

        Assert.IsNotNull(_context.HttpContext.Items[Item.UserLogged]);
        Assert.AreEqual(user, _context.HttpContext.Items[Item.UserLogged]);
    }

    [TestMethod]
    public void ShouldReturnInternalServerErrorWhenExceptionIsThrown()
    {
        var token = Guid.NewGuid().ToString();
        _context.HttpContext.Request.Headers[HeaderNames.Authorization] = token;
        _mockSessionService.Setup(s => s.ExpiredSession(It.IsAny<string>())).Returns(false);
        _mockSessionService.Setup(s => s.GetUserByToken(token)).Throws(new Exception("Token not found"));

        _filter.OnAuthorization(_context);

        var result = _context.Result as ObjectResult;
        Assert.IsNotNull(result, "Result should not be null");
        Assert.AreEqual((int)HttpStatusCode.InternalServerError, result.StatusCode);

        Assert.IsNotNull(result.Value, "Result value should not be null");

        var resultString = result.Value.ToString();
        StringAssert.Contains(resultString, "InternalError");
        StringAssert.Contains(resultString, "An error ocurred while processing the request: Token not found");
    }
}
