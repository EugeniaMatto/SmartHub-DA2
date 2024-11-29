using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using SmartHub.WebApi.Filters;

namespace SmartHub.Webapi.Test.FilterTests;
[TestClass]
public class ExceptionFilterTests
{
    private ExceptionFilter? _exceptionFilter;

    [TestInitialize]
    public void Setup()
    {
        _exceptionFilter = new ExceptionFilter();
    }

    [TestMethod]
    public void ShouldReturnMappedErrorForArgumentNullException()
    {
        var exception = new ArgumentNullException();
        var httpContext = new DefaultHttpContext();
        var actionContext = new ActionContext(httpContext, new Microsoft.AspNetCore.Routing.RouteData(), new ActionDescriptor());
        var context = new ExceptionContext(actionContext, [])
        {
            Exception = exception
        };

        _exceptionFilter.OnException(context);

        var result = context.Result as ObjectResult;
        Assert.IsNotNull(result);
        Assert.AreEqual((int)HttpStatusCode.BadRequest, result.StatusCode);
        Assert.AreEqual("InvalidArgument", result.Value.GetType().GetProperty("InnerCode")?.GetValue(result.Value));
    }

    [TestMethod]
    public void ShouldReturnInternalServerErrorForUnhandledException()
    {
        var exception = new Exception("Some internal error");
        var httpContext = new DefaultHttpContext();
        var actionContext = new ActionContext(httpContext, new Microsoft.AspNetCore.Routing.RouteData(), new ActionDescriptor());
        var context = new ExceptionContext(actionContext, [])
        {
            Exception = exception
        };

        _exceptionFilter.OnException(context);

        var result = context.Result as ObjectResult;
        Assert.IsNotNull(result);
        Assert.AreEqual((int)HttpStatusCode.InternalServerError, result.StatusCode);
        Assert.AreEqual("ServerError", result.Value.GetType().GetProperty("InnerCode")?.GetValue(result.Value));
    }

    [TestMethod]
    public void ShouldReturnInternalServerErrorWhenResponseIsNull()
    {
        var exception = new KeyNotFoundException("Key not found");
        var httpContext = new DefaultHttpContext();
        var actionContext = new ActionContext(httpContext, new Microsoft.AspNetCore.Routing.RouteData(), new ActionDescriptor());
        var context = new ExceptionContext(actionContext, [])
        {
            Exception = exception
        };

        _exceptionFilter.OnException(context);

        var result = context.Result as ObjectResult;
        Assert.IsNotNull(result);
        Assert.AreEqual((int)HttpStatusCode.InternalServerError, result.StatusCode);
    }
}
