using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class SmartLampServiceTests
{
    private Mock<IDeviceService>? _deviceServiceMock;
    private Mock<INotificationService>? _notificationServiceMock;
    private SmartLampService? _smartLampService;

    [TestInitialize]
    public void Setup()
    {
        _deviceServiceMock = new Mock<IDeviceService>();
        _notificationServiceMock = new Mock<INotificationService>();
        _smartLampService = new SmartLampService(_deviceServiceMock.Object, _notificationServiceMock.Object);
    }

    [TestMethod]
    public void AddSmartLamp_ShouldAddSmartLampDevice_WhenValidRequest()
    {
        var user = new User { Id = Guid.NewGuid() };
        var deviceRequest = new DeviceRequest
        {
            Name = "Smart Lamp",
            ModelNumber = "Model X",
            Description = "Smart Lamp with remote control",
            Photos = ["photo1.jpg"]
        };

        var result = _smartLampService.AddSmartLamp(deviceRequest, user);

        _deviceServiceMock.Verify(d => d.AddDevice(It.Is<Device>(dev =>
            dev.Name == deviceRequest.Name &&
            dev.Model == deviceRequest.ModelNumber &&
            dev.Type == DeviceType.SmartLamp &&
            dev.Description == deviceRequest.Description &&
            dev.Photos.SequenceEqual(deviceRequest.Photos)), user), Times.Once);

        Assert.AreNotEqual(Guid.Empty, result);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareFeatureNotSupportedException))]
    public void On_ShouldThrowException_WhenSmartLampIsAlreadyOn()
    {
        var hardwareId = Guid.NewGuid();
        var smartLampHardware = new SmartLampHardware
        {
            Device = new Device { Type = DeviceType.SmartLamp },
            IsOn = true
        };

        _deviceServiceMock.Setup(ds => ds.GetHardwareById(hardwareId)).Returns(smartLampHardware);

        _smartLampService.On(hardwareId);
    }

    [TestMethod]
    public void On_ShouldTurnOnSmartLamp_WhenLampIsOff()
    {
        var hardwareId = Guid.NewGuid();
        var smartLampHardware = new SmartLampHardware
        {
            Device = new Device { Type = DeviceType.SmartLamp },
            IsOn = false
        };

        _deviceServiceMock.Setup(ds => ds.GetHardwareById(hardwareId)).Returns(smartLampHardware);
        _notificationServiceMock.Setup(ns => ns.AddNotification(hardwareId, "Smart Lamp Alert: ON")).Returns([]);

        var result = _smartLampService.On(hardwareId);

        Assert.IsTrue(smartLampHardware.IsOn);
        _deviceServiceMock.Verify(ds => ds.UpdateHardware(smartLampHardware), Times.Once);
        _notificationServiceMock.Verify(ns => ns.AddNotification(hardwareId, "Smart Lamp Alert: ON"), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareFeatureNotSupportedException))]
    public void Off_ShouldThrowException_WhenSmartLampIsAlreadyOff()
    {
        var hardwareId = Guid.NewGuid();
        var smartLampHardware = new SmartLampHardware
        {
            Device = new Device { Type = DeviceType.SmartLamp },
            IsOn = false
        };

        _deviceServiceMock.Setup(ds => ds.GetHardwareById(hardwareId)).Returns(smartLampHardware);

        _smartLampService.Off(hardwareId);
    }

    [TestMethod]
    public void Off_ShouldTurnOffSmartLamp_WhenLampIsOn()
    {
        var hardwareId = Guid.NewGuid();
        var smartLampHardware = new SmartLampHardware
        {
            Device = new Device { Type = DeviceType.SmartLamp },
            IsOn = true
        };

        _deviceServiceMock.Setup(ds => ds.GetHardwareById(hardwareId)).Returns(smartLampHardware);
        _notificationServiceMock.Setup(ns => ns.AddNotification(hardwareId, "Smart Lamp Alert: OFF")).Returns([]);

        var result = _smartLampService.Off(hardwareId);

        Assert.IsFalse(smartLampHardware.IsOn);
        _deviceServiceMock.Verify(ds => ds.UpdateHardware(smartLampHardware), Times.Once);
        _notificationServiceMock.Verify(ns => ns.AddNotification(hardwareId, "Smart Lamp Alert: OFF"), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareNotCompatibleException))]
    public void On_ShouldThrowException_WhenHardwareIsNotSmartLamp()
    {
        var hardwareId = Guid.NewGuid();
        var nonSmartLampHardware = new Hardware
        {
            Device = new Device { Type = DeviceType.MotionSensor }
        };

        _deviceServiceMock.Setup(ds => ds.GetHardwareById(hardwareId)).Returns(nonSmartLampHardware);

        _smartLampService.On(hardwareId);
    }

    [TestMethod]
    public void SmartLampHardware_ToDeviceHome_ReturnsCorrectDeviceInfo()
    {
        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device C",
            Model = "Model 3",
            Type = DeviceType.SmartLamp,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var smartLamp = new SmartLampHardware
        {
            Name = "Living Room SmartLamp",
            Id = Guid.NewGuid(),
            Online = true,
            IsOn = true,
            Device = device
        };

        var result = new HardwareResponse(smartLamp);

        var resultType = result.GetType();

        Assert.AreEqual(smartLamp.Name, resultType.GetProperty("Name")?.GetValue(result));
        Assert.AreEqual(smartLamp.Id, resultType.GetProperty("Id")?.GetValue(result));
        Assert.AreEqual(smartLamp.Online, resultType.GetProperty("Online")?.GetValue(result));
        Assert.AreEqual(smartLamp.IsOn, resultType.GetProperty("IsOn")?.GetValue(result));
        Assert.IsNotNull(resultType.GetProperty("DeviceInfo")?.GetValue(result));
    }
}
