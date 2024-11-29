using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class MotionSensorServiceTests
{
    private MotionSensorService? _motionSensorService;
    private Mock<IDeviceService>? _mockDeviceService;
    private Mock<INotificationService>? _mockNotificationService;

    [TestInitialize]
    public void Setup()
    {
        _mockDeviceService = new Mock<IDeviceService>();
        _mockNotificationService = new Mock<INotificationService>();
        _motionSensorService = new MotionSensorService(_mockDeviceService.Object, _mockNotificationService.Object);
    }

    [TestMethod]
    public void AddMotionSensor_ShouldAddMotionSensor_WhenValidRequestIsProvided()
    {
        var deviceRequest = new DeviceRequest
        {
            Name = "Motion Sensor 1",
            ModelNumber = "Model123",
            Description = "Test motion sensor",
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

        var resultGuid = _motionSensorService.AddMotionSensor(deviceRequest, mockedUser);

        Assert.AreEqual(expectedGuid, resultGuid);
    }

    [TestMethod]
    public void MotionDetection_ShouldReturnNotifications_WhenMotionIsDetected()
    {
        var hardwareId = Guid.NewGuid();

        var hardware = new Hardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.MotionSensor
            }
        };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

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

        _mockNotificationService.Setup(repo => repo.AddNotification(hardwareId, "Motion Sensor Alert: Motion Detection"))
            .Returns(expectedNotifications);

        var result = _motionSensorService.MotionDetection(hardwareId);

        Assert.AreEqual(expectedNotifications, result);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareNotCompatibleException))]
    public void MotionDetection_ShouldThrowException_WhenDeviceIsNotMotionSensor()
    {
        var hardwareId = Guid.NewGuid();

        var hardware = new Hardware
        {
            Id = hardwareId,
            Device = new Device
            {
                Type = DeviceType.WindowSensor
            }
        };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

        _motionSensorService.MotionDetection(hardwareId);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), "Device not found.")]
    public void MotionDetection_ShouldThrowException_WhenHardwareNotFound()
    {
        var hardwareId = Guid.NewGuid();

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Throws(new Exception("Device not found."));

        _motionSensorService.MotionDetection(hardwareId);
    }
}
