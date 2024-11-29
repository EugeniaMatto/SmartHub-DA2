using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Moq;
using SmartHub.BussinesLogic;
using SmartHub.BussinesLogic.deviceImporter;
using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class DevicesControllerTests
{
    private Mock<IDeviceService>? _mockDeviceService;
    private DevicesController? _controller;
    private Mock<HttpContext>? _mockHttpContext;

    [TestInitialize]
    public void Setup()
    {
        _mockDeviceService = new Mock<IDeviceService>();
        _controller = new DevicesController(_mockDeviceService.Object);
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
    public void DevicesController_GetDevices_ReturnsOkResult_WithPaginatedDevices()
    {
        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device C",
            Model = "Model 3",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var expectedDevices = new List<Device> { device, device };

        var paginatedResult = new PaginatedResult<DeviceResponse>(
            expectedDevices.ConvertAll(d => new DeviceResponse(d, d.Company)),
            expectedDevices.Count,
            1,
            10);

        var filter = new DeviceFilterRequest
        {
            Name = null,
            Model = null,
            CompanyName = null,
            DeviceType = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockDeviceService.Setup(service => service.GetDevices(filter)).Returns(paginatedResult);

        var result = _controller.GetDevices(filter);

        Assert.IsTrue(result is OkObjectResult);

        var okResult = (OkObjectResult)result;
        Assert.IsTrue(okResult.Value is PaginatedResult<DeviceResponse>);

        var actualResult = (PaginatedResult<DeviceResponse>)okResult.Value;

        Assert.AreEqual(paginatedResult.TotalCount, actualResult.TotalCount);
        Assert.AreEqual(paginatedResult.PageNumber, actualResult.PageNumber);
        Assert.AreEqual(paginatedResult.PageSize, actualResult.PageSize);
        Assert.AreEqual(expectedDevices.Count, actualResult.Items.Count);
    }

    [TestMethod]
    public void DevicesController_ImportDevices_ReturnsOkResult_WithImportDevicesResponse()
    {
        var factory = new Mock<DeviceImporterFactory>();
        var user = new User { Email = "test@example.com", Password = "testpassword" };
        _mockHttpContext.Setup(c => c.Items["UserLogged"]).Returns(user);
        var request = new ImportDevicesRequest
        {
            Source = "test.json",
            Type = "json"
        };

        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Light Bulb",
            Model = "LB-100",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["b", "a"],
            Company = new Company()
            { Name = "AB" }
        };

        var expectedResponse = new ImportDevicesResponse(
            2,
            [
                new DeviceResponse(device, device.Company),
                new DeviceResponse(device, device.Company)
            ]);

        _mockDeviceService
            .Setup(service => service.ImportDevices(request, It.IsAny<User>()))
            .Returns(expectedResponse);

        var result = _controller.ImportDevices(request);

        Assert.IsTrue(result is OkObjectResult);

        var okResult = (OkObjectResult)result;
        Assert.IsTrue(okResult.Value is ImportDevicesResponse);

        var actualResponse = (ImportDevicesResponse)okResult.Value;

        Assert.AreEqual(expectedResponse.Total, actualResponse.Total);
        Assert.AreEqual(expectedResponse.Devices.Count, actualResponse.Devices.Count);
    }

    [TestMethod]
    public void DevicesController_GetImporters_ReturnsOkResult_WithRegisteredImporters()
    {
        var expectedImporters = new List<string> { "json" };

        _mockDeviceService
            .Setup(service => service.GetRegisteredImporters())
            .Returns(["json"]);

        var result = _controller.GetImporters();

        Assert.IsTrue(result is OkObjectResult);

        var okResult = (OkObjectResult)result;
        Assert.IsTrue(okResult.Value is List<string>);

        var actualImporters = (List<string>)okResult.Value;
        CollectionAssert.AreEquivalent(expectedImporters, actualImporters);
    }

    [TestMethod]
    public void DevicesController_SelectDeviceModelValidator_ReturnsOkResult_WithResponseMessage()
    {
        var request = new DeviceModelValidatorRequest { Validator = "ValidatorName" };
        var expectedResponse = "Validator ValidatorName selected successfully";
        var user = new User { Email = "test@example.com", Password = "testpassword" };

        _mockHttpContext.Setup(c => c.Items["UserLogged"]).Returns(user);
        _mockDeviceService
            .Setup(service => service.SelectDeviceValidator(request.Validator, It.IsAny<User>()))
            .Returns(expectedResponse);

        var result = _controller.SelectDeviceModelValidator(request) as OkObjectResult;
        Assert.AreEqual("{ msg = Validator ValidatorName selected successfully }", result.Value.ToString());
    }

    [TestMethod]
    public void DevicesController_GetDeviceModelValidators_ReturnsOkResult_WithValidatorsList()
    {
        var expectedValidators = new List<string> { "Validator1", "Validator2" };
        _mockDeviceService
            .Setup(service => service.GetRegisteredValidators())
            .Returns(expectedValidators);

        var result = _controller.GetDeviceModelValidators();

        Assert.IsTrue(result is OkObjectResult);

        var okResult = (OkObjectResult)result;
        Assert.IsTrue(okResult.Value is List<string>);

        var actualValidators = (List<string>)okResult.Value;
        CollectionAssert.AreEquivalent(expectedValidators, actualValidators);
    }
}
