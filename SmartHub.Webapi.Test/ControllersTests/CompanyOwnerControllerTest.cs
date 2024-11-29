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
public class CompanyOwnerControllerTests
{
    private Mock<ICompanyOwnerService>? _mockCompanyOwnerService;
    private Mock<ISessionsService>? _mockSessionsService;
    private CompanyOwnerController? _controller;

    [TestInitialize]
    public void Setup()
    {
        _mockCompanyOwnerService = new Mock<ICompanyOwnerService>();
        _mockSessionsService = new Mock<ISessionsService>();
        _controller = new CompanyOwnerController(_mockCompanyOwnerService.Object, _mockSessionsService.Object);
    }

    [TestMethod]
    public void CreateCompanyOwnerAccount_ShouldReturnOk_WithToken()
    {
        var newAccount = new CompanyOwnerRequest
        {
            Name = "Company Owner",
            Surname = "Doe",
            Email = "owner.doe@example.com",
            Password = "P@ssword123"
        };
        var expectedToken = Guid.NewGuid();
        var expectedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "Company Owner",
            Surname = "Doe",
            Email = "owner.doe@example.com"
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

        _mockCompanyOwnerService.Setup(service => service.CreateCompanyOwnerAccount(newAccount))
            .Returns(expectedUser);
        _mockSessionsService.Setup(service => service.AddSession(expectedUser))
            .Returns(expectedSessionResponse);

        var result = _controller!.CreateCompanyOwnerAccount(newAccount) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(expectedSessionResponse, result.Value?.GetType().GetProperty("Token")?.GetValue(result.Value));
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void CreateCompanyOwnerAccount_ShouldThrowValidationException_WhenModelStateIsInvalid()
    {
        var newAccount = new CompanyOwnerRequest
        {
            Name = string.Empty,
            Surname = "Doe",
            Email = "owner.doe@example.com",
            Password = "P@ssword123"
        };

        _controller!.ModelState.AddModelError("Name", "The Name field is required.");

        _controller.CreateCompanyOwnerAccount(newAccount);
    }

    [TestMethod]
    public void CreateCompanyOwnerAccount_ShouldCallServices_WhenValidRequest()
    {
        var newAccount = new CompanyOwnerRequest
        {
            Name = "Company Owner",
            Surname = "Doe",
            Email = "owner.doe@example.com",
            Password = "SecurePassword123"
        };

        var expectedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "Company Owner",
            Surname = "Doe",
            Email = "owner.doe@example.com"
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
        _mockCompanyOwnerService.Setup(service => service.CreateCompanyOwnerAccount(newAccount))
            .Returns(expectedUser);
        _mockSessionsService.Setup(service => service.AddSession(expectedUser))
            .Returns(expectedSessionResponse);

        var result = _controller!.CreateCompanyOwnerAccount(newAccount) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(expectedSessionResponse, result.Value?.GetType().GetProperty("Token")?.GetValue(result.Value));
        _mockCompanyOwnerService.Verify(service => service.CreateCompanyOwnerAccount(newAccount), Times.Once);
        _mockSessionsService.Verify(service => service.AddSession(expectedUser), Times.Once);
    }
}
