using Microsoft.AspNetCore.Http;
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
public class CompaniesControllerTest
{
    private Mock<ICompanyService>? _mockService;
    private CompaniesController? _controller;
    private Mock<HttpContext>? _mockHttpContext;

    [TestInitialize]
    public void Setup()
    {
        _mockService = new Mock<ICompanyService>();
        _controller = new CompaniesController(_mockService.Object);
        _mockHttpContext = new Mock<HttpContext>();

        var items = new Dictionary<object, object>
        {
            { "UserLogged", new User { Email = "test@example.com", Password = "testpassword" } }
        };

        _mockHttpContext.Setup(c => c.Items).Returns(items);
        _controller.ControllerContext = new ControllerContext
        {
            HttpContext = _mockHttpContext.Object
        };
    }

    [TestMethod]
    public void CreateCompany_ShouldReturnOk_WhenCompanyIsCreated()
    {
        var request = new CompanyRequest
        {
            Name = "New Company",
            LogoUrl = "http://example.com/logo.png",
            Rut = "98765432-1"
        };
        var user = new User { Id = Guid.NewGuid(), Email = "owner@example.com" };
        _controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext()
        };
        _controller.HttpContext.Items["LoggedUser"] = user;
        _mockService.Setup(service => service.CreateCompany(request, user)).Returns(Guid.NewGuid());
        var result = _controller.CreateCompany(request);
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void CreateCompany_ShouldReturnBadRequest_WhenModelStateIsInvalid()
    {
        _controller.ModelState.AddModelError("Name", "El request es inválido");

        var request = new CompanyRequest
        {
            Name = string.Empty,
            LogoUrl = "http://example.com/logo.png",
            Rut = "98765432-1"
        };

        var exception = Assert.ThrowsException<ValidationException>(() => _controller.CreateCompany(request));
    }

    [TestMethod]
    public void GetCompany_ShouldReturnOk_WithPaginatedCompanies_WhenCompaniesExist()
    {
        var expectedCompanies = new List<CompanyNoDevicesResponse>
    {
        new CompanyNoDevicesResponse { Name = "Company A", Logo = "http://example.com/logoA.png", Rut = "12345678-9", Owner = "Owner A", OwnerEmail = "ownerA@example.com" },
        new CompanyNoDevicesResponse { Name = "Company B", Logo = "http://example.com/logoB.png", Rut = "98765432-1", Owner = "Owner B", OwnerEmail = "ownerB@example.com" }
    };

        var paginatedResult = new PaginatedResult<CompanyNoDevicesResponse>(
            expectedCompanies,
            expectedCompanies.Count,
            1,
            10);

        var filter = new CompanyFilterRequest
        {
            CompanyName = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockService.Setup(service => service.GetAllCompanies(filter)).Returns(paginatedResult);

        var result = _controller.GetCompany(filter);

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult, "Expected OkObjectResult.");
        var actualResult = okResult.Value as PaginatedResult<CompanyNoDevicesResponse>?;
        Assert.IsNotNull(actualResult, "Expected PaginatedResult<CompanyModel>.");

        Assert.AreEqual(paginatedResult, actualResult);
    }

    [TestMethod]
    public void GetCompany_ShouldReturnOk_WithEmptyList_WhenNoCompaniesExist()
    {
        var paginatedResult = new PaginatedResult<CompanyNoDevicesResponse>(
            [],
            0,
            1,
            10);

        var filter = new CompanyFilterRequest
        {
            CompanyName = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockService.Setup(service => service.GetAllCompanies(filter)).Returns(paginatedResult);

        var result = _controller.GetCompany(filter);

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult, "Expected OkObjectResult.");
        var actualResult = okResult.Value as PaginatedResult<CompanyNoDevicesResponse>?;
        Assert.IsNotNull(actualResult, "Expected PaginatedResult<CompanyModel>.");

        Assert.AreEqual(paginatedResult, actualResult);
    }

    [TestMethod]
    public void GetCompanyUser_ShouldReturnOk_WithCompanyResponse_WhenCompanyExists()
    {
        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Light Bulb",
            Model = "LB-100",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["a", "b"],
            Company = new Company()
            { Name = "AB" }
        };

        var companyResponse = new CompanyResponse(
            "Test Company",
            "http://example.com/logo.png",
            "12345678-9",
            [new DeviceResponse(device, device.Company), new DeviceResponse(device, device.Company)],
            string.Empty);

        var user = new User { Id = Guid.NewGuid(), Email = "owner@example.com" };
        _controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext()
        };
        _controller.HttpContext.Items["LoggedUser"] = user;

        _mockService.Setup(service => service.GetCompany(It.IsAny<User>())).Returns(companyResponse);
        var result = _controller.GetCompanyUser();

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult, "Expected OkObjectResult.");
        var actualResponse = okResult.Value as CompanyResponse?;
        Assert.IsNotNull(actualResponse, "Expected CompanyResponse.");
        Assert.AreEqual(companyResponse, (CompanyResponse)actualResponse);
    }
}
