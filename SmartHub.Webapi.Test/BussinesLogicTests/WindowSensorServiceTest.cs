using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class SensorServiceTests
{
    private WindowSensorService? _sensorService;
    private Mock<IDeviceService>? _mockDeviceService;
    private Mock<INotificationService>? _mockNotificationService;

    [TestInitialize]
    public void Setup()
    {
        _mockDeviceService = new Mock<IDeviceService>();
        _mockNotificationService = new Mock<INotificationService>();
        _sensorService = new WindowSensorService(_mockDeviceService.Object, _mockNotificationService.Object);
    }

    [TestMethod]
    public void AddSensor_ShouldAddSensor_WhenValidRequestIsProvided()
    {
        var deviceRequest = new DeviceRequest
        {
            Name = "Window Sensor 1",
            ModelNumber = "ModelXYZ",
            Description = "Test window sensor",
            Photos = new[] { "photo1.jpg", "photo2.jpg" }.ToList(),
        };

        var mockedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "Test",
            Surname = "User",
            Email = "test@example.com"
        };

        var expectedGuid = Guid.NewGuid();

        _mockDeviceService.Setup(repo => repo.AddDevice(It.IsAny<Device>(), It.IsAny<User>()))
            .Callback<Device, User>((device, user) => device.Id = expectedGuid);

        var resultGuid = _sensorService!.AddSensor(deviceRequest, mockedUser);

        Assert.AreEqual(expectedGuid, resultGuid);
    }

    [TestMethod]
    public void Open_ShouldReturnNotifications_WhenSensorOpens()
    {
        var hardwareId = Guid.NewGuid();

        var windowSensor = new WindowSensorHardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.WindowSensor
            },
            IsOpen = false
        };

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(windowSensor);
        var user1 = new User { Id = Guid.NewGuid(), Name = "John Doe", Email = "johndoe@example.com" };
        var user2 = new User { Id = Guid.NewGuid(), Name = "Jane Smith", Email = "janesmith@example.com" };

        var notification1 = new Notification
        {
            Id = Guid.NewGuid(),
            HardwareId = Guid.NewGuid(),
            Event = "Thermostat added to home",
            Seen = false,
            UserId = user1.Id,
            User = user1,
            UserEmail = user1.Email
        };

        var notification2 = new Notification
        {
            Id = Guid.NewGuid(),
            HardwareId = Guid.NewGuid(),
            Event = "Light Bulb added to home",
            Seen = true,
            UserId = user2.Id,
            User = user2,
            UserEmail = user2.Email
        };
        var expectedNotifications = new List<NotificationResponse> { new NotificationResponse(notification1), new NotificationResponse(notification2) };

        _mockNotificationService!.Setup(repo => repo.AddNotification(hardwareId, "Window Sensor Alert: Open"))
            .Returns(expectedNotifications);

        var result = _sensorService.Open(hardwareId);

        Assert.AreEqual(expectedNotifications, result);
        Assert.IsTrue(windowSensor.IsOpen);
        var notificationResponse = result.FirstOrDefault(n => n.Id == notification1.Id);
        Assert.IsNotNull(notificationResponse);
        Assert.AreEqual(notification1.Event, notificationResponse.Event);
        Assert.AreEqual(notification1.Seen, notificationResponse.Seen);
    }

    [TestMethod]
    public void Close_ShouldReturnNotifications_WhenSensorCloses()
    {
        var hardwareId = Guid.NewGuid();

        var windowSensor = new WindowSensorHardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.WindowSensor
            },
            IsOpen = true
        };

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(windowSensor);
        var user1 = new User { Id = Guid.NewGuid(), Name = "John Doe", Email = "johndoe@example.com" };
        var user2 = new User { Id = Guid.NewGuid(), Name = "Jane Smith", Email = "janesmith@example.com" };

        var notification1 = new Notification
        {
            Id = Guid.NewGuid(),
            HardwareId = Guid.NewGuid(),
            Event = "Thermostat added to home",
            Seen = false,
            UserId = user1.Id,
            User = user1,
            UserEmail = user1.Email
        };

        var notification2 = new Notification
        {
            Id = Guid.NewGuid(),
            HardwareId = Guid.NewGuid(),
            Event = "Light Bulb added to home",
            Seen = true,
            UserId = user2.Id,
            User = user2,
            UserEmail = user2.Email
        };
        var expectedNotifications = new List<NotificationResponse> { new NotificationResponse(notification1), new NotificationResponse(notification2) };

        _mockNotificationService!.Setup(repo => repo.AddNotification(hardwareId, "Window Sensor Alert: Closed"))
            .Returns(expectedNotifications);

        var result = _sensorService.Close(hardwareId);

        Assert.AreEqual(expectedNotifications, result);
        Assert.IsFalse(windowSensor.IsOpen);
    }

    [TestMethod]
    public void Open_ShouldThrowException_WhenDeviceIsNotWindowSensor()
    {
        var hardwareId = Guid.NewGuid();

        var hardware = new Hardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.SecurityCam
            }
        };

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

        var exception = Assert.ThrowsException<HardwareNotCompatibleException>(() => _sensorService!.Open(hardwareId));
    }

    [TestMethod]
    public void Close_ShouldThrowException_WhenDeviceIsNotWindowSensor()
    {
        var hardwareId = Guid.NewGuid();

        var hardware = new Hardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.SecurityCam
            }
        };

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

        var exception = Assert.ThrowsException<HardwareNotCompatibleException>(() => _sensorService!.Close(hardwareId));
    }

    [TestMethod]
    public void Open_ShouldThrowException_WhenSensorIsAlreadyOpen()
    {
        var hardwareId = Guid.NewGuid();

        var windowSensor = new WindowSensorHardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.WindowSensor
            },
            IsOpen = true
        };

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(windowSensor);

        var exception = Assert.ThrowsException<HardwareFeatureNotSupportedException>(() => _sensorService!.Open(hardwareId));
    }

    [TestMethod]
    public void Close_ShouldThrowException_WhenSensorIsAlreadyClosed()
    {
        var hardwareId = Guid.NewGuid();

        var windowSensor = new WindowSensorHardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.WindowSensor
            },
            IsOpen = false
        };

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(windowSensor);

        var exception = Assert.ThrowsException<HardwareFeatureNotSupportedException>(() => _sensorService!.Close(hardwareId));
    }

    [TestMethod]
    public void Open_ShouldThrowException_WhenHardwareNotFound()
    {
        var hardwareId = Guid.NewGuid();

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Throws(new Exception("Device not found."));

        var exception = Assert.ThrowsException<Exception>(() => _sensorService!.Open(hardwareId));
        Assert.AreEqual("Device not found.", exception.Message);
    }

    [TestMethod]
    public void Close_ShouldThrowException_WhenHardwareNotFound()
    {
        var hardwareId = Guid.NewGuid();

        _mockDeviceService!.Setup(repo => repo.GetHardwareById(hardwareId)).Throws(new Exception("Device not found."));

        var exception = Assert.ThrowsException<Exception>(() => _sensorService!.Close(hardwareId));
        Assert.AreEqual("Device not found.", exception.Message);
    }

    [TestMethod]
    public void WindowSensorHardware_ToDeviceHome_ReturnsCorrectDeviceInfo()
    {
        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device C",
            Model = "Model 3",
            Type = DeviceType.WindowSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var windowSensor = new WindowSensorHardware
        {
            Name = "Living Room Window Sensor",
            Id = Guid.NewGuid(),
            Online = true,
            IsOpen = true,
            Device = device
        };

        var result = new HardwareResponse(windowSensor);

        var resultType = result.GetType();

        Assert.AreEqual(windowSensor.Name, resultType.GetProperty("Name")?.GetValue(result));
        Assert.AreEqual(windowSensor.Id, resultType.GetProperty("Id")?.GetValue(result));
        Assert.AreEqual(windowSensor.Online, resultType.GetProperty("Online")?.GetValue(result));
        Assert.AreEqual(windowSensor.IsOpen, resultType.GetProperty("IsOpen")?.GetValue(result));
        Assert.IsNotNull(resultType.GetProperty("DeviceInfo")?.GetValue(result));
    }

    [TestMethod]
    public void WindowSensorHardware_ToDeviceHome_WhenSensorIsClosed_ReturnsCorrectDeviceInfo()
    {
        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device C",
            Model = "Model 3",
            Type = DeviceType.WindowSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var windowSensor = new WindowSensorHardware
        {
            Name = "Bedroom Window Sensor",
            Id = Guid.NewGuid(),
            Online = false,
            IsOpen = false,
            Device = device
        };

        var result = new HardwareResponse(windowSensor);

        var resultType = result.GetType();

        Assert.AreEqual(windowSensor.Name, resultType.GetProperty("Name")?.GetValue(result));
        Assert.AreEqual(windowSensor.Id, resultType.GetProperty("Id")?.GetValue(result));
        Assert.AreEqual(windowSensor.Online, resultType.GetProperty("Online")?.GetValue(result));
        Assert.AreEqual(windowSensor.IsOpen, resultType.GetProperty("IsOpen")?.GetValue(result));
        Assert.IsNotNull(resultType.GetProperty("DeviceInfo")?.GetValue(result));
    }
}
