using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;
using SmartHub.WebApi;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class HomeOwnerControllerTests
{
    private Mock<IHomeOwnerService>? _mockHomeOwnerService;
    private Mock<ISessionsService>? _mockSessionsService;
    private HomeOwnerController? _controller;

    [TestInitialize]
    public void Setup()
    {
        _mockHomeOwnerService = new Mock<IHomeOwnerService>();
        _mockSessionsService = new Mock<ISessionsService>();
        _controller = new HomeOwnerController(_mockHomeOwnerService.Object, _mockSessionsService.Object);
    }

    [TestMethod]
    public void CreateHomeOwnerAccount_ShouldReturnOk_WithToken()
    {
        var newHomeOwner = new HomeOwnerRequest
        {
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Password = "P@ssword123",
            ProfilePhoto = "photo.jpg"
        };

        var expectedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com"
        };

        var expectedToken = Guid.NewGuid();
        var expectedSessionResponse = new SessionResponse(
            expectedUser.Id,
            expectedToken,
            [],
            expectedUser.Name,
            string.Empty,
            string.Empty,
            string.Empty,
            DateTime.UtcNow);

        _mockHomeOwnerService.Setup(service => service.CreateHomeOwnerAccount(newHomeOwner))
            .Returns(expectedUser);
        _mockSessionsService.Setup(service => service.AddSession(expectedUser))
            .Returns(expectedSessionResponse);

        var result = _controller!.CreateHomeOwnerAccount(newHomeOwner) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(expectedSessionResponse, result.Value);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void CreateHomeOwnerAccount_ShouldThrowValidationException_WhenModelStateIsInvalid()
    {
        var newHomeOwner = new HomeOwnerRequest
        {
            Name = string.Empty,
            Surname = "Doe",
            Email = "john.doe@example.com",
            Password = "P@ssword123",
            ProfilePhoto = "photo.jpg"
        };

        _controller!.ModelState.AddModelError("Name", "The Name field is required.");

        _controller.CreateHomeOwnerAccount(newHomeOwner);
    }

    [TestMethod]
    public void CreateHomeOwnerAccount_ShouldCallServices_WhenValidRequest()
    {
        var newHomeOwner = new HomeOwnerRequest
        {
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Password = "P@ssword123",
            ProfilePhoto = "photo.jpg"
        };

        var expectedToken = Guid.NewGuid();
        var expectedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com"
        };
        var expectedSessionResponse = new SessionResponse(
            expectedUser.Id,
            expectedToken,
            [],
            expectedUser.Name,
            string.Empty,
            string.Empty,
            string.Empty,
            DateTime.UtcNow);

        _mockHomeOwnerService.Setup(service => service.CreateHomeOwnerAccount(newHomeOwner))
            .Returns(expectedUser);
        _mockSessionsService.Setup(service => service.AddSession(expectedUser))
            .Returns(expectedSessionResponse);

        var result = _controller!.CreateHomeOwnerAccount(newHomeOwner) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(expectedSessionResponse, result.Value);
        _mockHomeOwnerService.Verify(service => service.CreateHomeOwnerAccount(newHomeOwner), Times.Once);
        _mockSessionsService.Verify(service => service.AddSession(expectedUser), Times.Once);
    }

    [TestMethod]
    public void AddHomeOwnerPermission_ShouldReturnOk_WhenPermissionAddedSuccessfully()
    {
        var user = new User { Id = Guid.NewGuid(), Name = "Test User" };
        _controller!.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext()
        };
        _controller.ControllerContext.HttpContext.Items[Item.UserLogged] = user;

        var result = _controller.AddHomeOwnerPermission() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("Permissions added successfully.", result.Value?.GetType().GetProperty("msg")?.GetValue(result.Value));
    }

    [TestMethod]
    public void AddHomeOwnerPermission_ShouldCallAddPermissionToUser()
    {
        var user = new User { Id = Guid.NewGuid(), Name = "Test User" };
        _controller!.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext()
        };
        _controller.ControllerContext.HttpContext.Items[Item.UserLogged] = user;

        _controller.AddHomeOwnerPermission();

        _mockHomeOwnerService!.Verify(service => service.AddPermissionToUser(user), Times.Once);
    }

    [TestMethod]
    public void GetEmails_ShouldReturnOk_WithEmails()
    {
        var expectedEmails = new List<string> { "user1@example.com", "user2@example.com" };

        _mockHomeOwnerService.Setup(service => service.GetUserEmails())
            .Returns(expectedEmails);

        var result = _controller!.GetEmails() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(expectedEmails, result.Value);
    }
}
