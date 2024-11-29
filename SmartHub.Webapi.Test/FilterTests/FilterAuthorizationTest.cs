using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.WebApi;
using SmartHub.WebApi.Filters;

namespace SmartHub.Webapi.Test.FilterTests;
[TestClass]
public class AuthorizationFilterTests
{
    private Mock<IPermissionService>? _mockPermissionService;
    private AuthorizationFilterContext? _context;
    private AuthorizationFilterAttribute? _filter;
    private User? _testUser;

    [TestInitialize]
    public void Setup()
    {
        _mockPermissionService = new Mock<IPermissionService>();

        var httpContext = new DefaultHttpContext();
        var routeData = new RouteData();
        routeData.Values["action"] = "TestAction";
        routeData.Values["controller"] = "TestController";

        var actionDescriptor = new ActionDescriptor();

        var actionContext = new ActionContext
        {
            HttpContext = httpContext,
            RouteData = routeData,
            ActionDescriptor = actionDescriptor
        };

        _context = new AuthorizationFilterContext(actionContext, []);
        _testUser = new User { Email = "test@example.com" };

        httpContext.RequestServices = new ServiceCollection()
            .AddSingleton(_mockPermissionService.Object)
            .BuildServiceProvider();
    }

    [TestMethod]
    public void ShouldReturnUnauthorizedWhenUserIsNotLoggedIn()
    {
        _filter = new AuthorizationFilterAttribute();
        _filter.OnAuthorization(_context!);

        var result = _context!.Result as ObjectResult;
        Assert.IsNotNull(result, "Result should not be null");

        Assert.AreEqual((int)HttpStatusCode.Unauthorized, result?.StatusCode ?? 401);

        StringAssert.Contains(result!.Value.ToString(), "UnAuthorized");
        StringAssert.Contains(result.Value.ToString(), "Not authenticated");
    }

    [TestMethod]
    public void ShouldReturnForbiddenWhenUserDoesNotHavePermission()
    {
        _context.HttpContext.Items[Item.UserLogged] = _testUser;
        _mockPermissionService.Setup(p => p.UserHasPermission(It.IsAny<string>(), It.IsAny<string>())).Returns(false);

        _filter = new AuthorizationFilterAttribute();
        _filter.OnAuthorization(_context);

        var result = _context.Result as ObjectResult;
        Assert.IsNotNull(result);
        Assert.AreEqual((int)HttpStatusCode.Forbidden, result.StatusCode);
        StringAssert.Contains(result.Value.ToString(), "Forbidden");
        StringAssert.Contains(result.Value.ToString(), "Missing permission");
    }

    [TestMethod]
    public void ShouldAllowAccessWhenUserHasPermission()
    {
        _context.HttpContext.Items[Item.UserLogged] = _testUser;
        _mockPermissionService.Setup(p => p.UserHasPermission(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

        _filter = new AuthorizationFilterAttribute();
        _filter.OnAuthorization(_context);

        Assert.IsNull(_context.Result);
    }
}
