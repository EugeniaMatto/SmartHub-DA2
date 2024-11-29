using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class AdministratorControllerTests
{
    private Mock<IAdministratorService>? _mockAdministratorService;
    private Mock<ISessionsService>? _mockSessionsService;
    private AdministratorController? _controller;

    [TestInitialize]
    public void Setup()
    {
        _mockAdministratorService = new Mock<IAdministratorService>();
        _mockSessionsService = new Mock<ISessionsService>();
        _controller = new AdministratorController(_mockAdministratorService.Object, _mockSessionsService.Object);
    }

    [TestMethod]
    public void CreateAdminAccount_ShouldReturnOk_WithToken()
    {
        var newAdmin = new AdministratorRequest
        {
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Password = "P@ssword123"
        };

        var expectedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Roles = [Role.Administrator]
        };

        var expectedToken = Guid.NewGuid();
        var expectedSessionResponse = new SessionResponse(
            expectedUser.Id,
            expectedToken,
            [expectedUser.Roles.ToString()],
            expectedUser.Name,
            expectedUser.Surname,
            expectedUser.Email,
            expectedUser.ProfilePhoto,
            DateTime.UtcNow);
        _mockAdministratorService.Setup(service => service.CreateAdminAccount(newAdmin))
            .Returns(expectedUser);
        _mockSessionsService.Setup(service => service.AddSession(expectedUser))
            .Returns(expectedSessionResponse);

        var result = _controller!.CreateAdminAccount(newAdmin) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(expectedSessionResponse, result.Value);
    }

    [TestMethod]
    public void DeleteAdminAccount_ShouldReturnOk_WhenAccountIsDeleted()
    {
        var accountId = Guid.NewGuid();

        var result = _controller.DeleteAdminAccount(accountId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        _mockAdministratorService.Verify(service => service.DeleteAdminAccount(accountId), Times.Once);
    }

    [TestMethod]
    public void CreateAdminAccount_ShouldCallServices_WhenValidRequest()
    {
        var newAdmin = new AdministratorRequest
        {
            Name = "Jane",
            Surname = "Doe",
            Email = "jane.doe@example.com",
            Password = "SecurePassword123"
        };

        var expectedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "Jane",
            Surname = "Doe",
            Email = "jane.doe@example.com",
            Roles = [Role.Administrator]
        };

        var expectedToken = Guid.NewGuid();
        var expectedSessionResponse = new SessionResponse(
            expectedUser.Id,
            expectedToken,
            [expectedUser.Roles.ToString()],
            expectedUser.Name,
            expectedUser.Surname,
            expectedUser.Email,
            expectedUser.ProfilePhoto,
            DateTime.UtcNow);

        _mockAdministratorService.Setup(service => service.CreateAdminAccount(newAdmin))
            .Returns(expectedUser);
        _mockSessionsService.Setup(service => service.AddSession(expectedUser))
            .Returns(expectedSessionResponse);

        var result = _controller!.CreateAdminAccount(newAdmin) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        Assert.AreEqual(expectedSessionResponse,
             result.Value);

        _mockAdministratorService.Verify(service => service.CreateAdminAccount(newAdmin), Times.Once);
        _mockSessionsService.Verify(service => service.AddSession(expectedUser), Times.Once);

        Assert.AreEqual(expectedSessionResponse.Token, expectedSessionResponse.Token);
        Assert.AreEqual(expectedSessionResponse.Roles.Count, expectedSessionResponse.Roles.Count);
        Assert.AreEqual(expectedSessionResponse.Roles[0], expectedSessionResponse.Roles[0]);
        Assert.AreEqual(expectedSessionResponse.Name, expectedSessionResponse.Name);
        Assert.AreEqual(expectedSessionResponse.Surname, expectedSessionResponse.Surname);
        Assert.AreEqual(expectedSessionResponse.Email, expectedSessionResponse.Email);
        Assert.AreEqual(expectedSessionResponse.ProfilePhoto, expectedSessionResponse.ProfilePhoto);
        Assert.IsTrue((expectedSessionResponse.CreatedAt - expectedSessionResponse.CreatedAt).TotalSeconds < 1);
    }

    [TestMethod]
    public void DeleteAdminAccount_ShouldCallService_WhenValidRequest()
    {
        var accountId = Guid.NewGuid();

        _controller!.DeleteAdminAccount(accountId);

        _mockAdministratorService!.Verify(service => service.DeleteAdminAccount(accountId), Times.Once);
    }

    [TestMethod]
    public void CreateAdminAccount_WhenInValidRequest()
    {
        _controller.ModelState.AddModelError("Name", "El request es inválido");
        var request = new AdministratorRequest
        {
            Name = string.Empty,
            Surname = "Doe",
            Email = string.Empty,
            Password = string.Empty
        };

        var exception = Assert.ThrowsException<ValidationException>(() => _controller.CreateAdminAccount(request));
    }
}
