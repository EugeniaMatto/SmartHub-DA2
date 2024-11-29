using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.WebApi;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class SmartHubBaseControllerTestable : SmartHubBaseController
{
    public new User GetUserLogged()
    {
        return base.GetUserLogged();
    }

    public new void NotValidModel()
    {
        base.NotValidModel();
    }
}

[TestClass]
public class SmartHubBaseControllerTests
{
    private SmartHubBaseControllerTestable? _controller;
    private Mock<HttpContext>? _mockHttpContext;

    [TestInitialize]
    public void Setup()
    {
        _controller = new SmartHubBaseControllerTestable();
        _mockHttpContext = new Mock<HttpContext>();

        var items = new Dictionary<object, object>
        {
            { Item.UserLogged, new User { Email = "test@example.com", Password = "testpassword", Name = "Test", Surname = "User" } }
        };

        _mockHttpContext.Setup(c => c.Items).Returns(items);
        _controller.ControllerContext = new ControllerContext
        {
            HttpContext = _mockHttpContext.Object
        };
    }

    [TestMethod]
    public void GetUserLogged_ShouldReturnLoggedUser()
    {
        var result = _controller.GetUserLogged();

        Assert.IsNotNull(result);
        Assert.AreEqual("test@example.com", result.Email);
        Assert.AreEqual("Test", result.Name);
        Assert.AreEqual("User", result.Surname);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void NotValidModel_ShouldThrowValidationException_WhenModelStateIsInvalid()
    {
        _controller.ModelState.AddModelError("Field1", "Field1 is required");

        _controller.NotValidModel();
    }
}
