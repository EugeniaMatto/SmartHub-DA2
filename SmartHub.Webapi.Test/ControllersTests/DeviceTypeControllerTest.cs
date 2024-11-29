using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class DeviceTypeControllerTest
{
    private Mock<IDeviceService>? _mockDeviceService;
    private DeviceTypeController? _deviceTypeController;

    [TestInitialize]
    public void Setup()
    {
        _mockDeviceService = new Mock<IDeviceService>();
        _deviceTypeController = new DeviceTypeController(_mockDeviceService.Object);
    }

    [TestMethod]
    public void GetDeviceTypes_ShouldReturnOk_WithListOfDeviceTypes()
    {
        var deviceTypes = new List<string> { "Camera", "Sensor" };

        _mockDeviceService.Setup(service => service.GetDeviceTypes()).Returns(deviceTypes);

        var result = _deviceTypeController.GetDeviceTypes() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.IsInstanceOfType(result.Value, typeof(List<string>));
        var returnedDeviceTypes = result.Value as List<string>;
        Assert.AreEqual(2, returnedDeviceTypes.Count);
    }

    [TestMethod]
    public void GetDeviceTypes_ShouldReturnEmptyList_WhenNoDeviceTypesExist()
    {
        var emptyDeviceTypes = new List<string>();
        _mockDeviceService.Setup(service => service.GetDeviceTypes()).Returns(emptyDeviceTypes);

        var result = _deviceTypeController.GetDeviceTypes() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        var returnedDeviceTypes = result.Value as List<string>;
        Assert.IsNotNull(returnedDeviceTypes);
        Assert.AreEqual(0, returnedDeviceTypes.Count);
    }
}
