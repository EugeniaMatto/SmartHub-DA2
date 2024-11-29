using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class CameraServiceTests
{
    private CameraService? _cameraService;
    private Mock<IDeviceService>? _mockDeviceService;
    private Mock<INotificationService>? _mockNotificationService;

    [TestInitialize]
    public void Setup()
    {
        _mockDeviceService = new Mock<IDeviceService>();
        _mockNotificationService = new Mock<INotificationService>();
        _cameraService = new CameraService(_mockDeviceService.Object, _mockNotificationService.Object);
    }

    [TestMethod]
    public void AddCamera_ShouldAddCamera_WhenValidRequestIsProvided()
    {
        var deviceRequest = new DeviceCamRequest
        {
            Name = "Camera 1",
            ModelNumber = "Model123",
            Description = "Test camera",
            Photos = new[] { "photo1.jpg", "photo2.jpg" }.ToList(),
            UseTypes = new[] { "Indoor", "Outdoor" }.ToList(),
            SupportedActions = new[] { "PersonDetection", "MotionDetection" }.ToList()
        };

        var mockedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "Test",
            Surname = "User",
            Email = "test@example.com",
            Roles = [Role.CompanyOwner]
        };
        var expectedGuid = Guid.NewGuid();
        _mockDeviceService.Setup(repo => repo.AddDevice(It.IsAny<Device>(), It.IsAny<User>()))
        .Callback<Device, User>((device, user) => device.Id = expectedGuid);

        var resultGuid = _cameraService.AddCamera(deviceRequest, mockedUser);
        Assert.AreEqual(expectedGuid, resultGuid);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareNotCompatibleException))]
    public void PersonDetection_ShouldThrowException_WhenHardwareIsNotSecurityCam()
    {
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Id = hardwareId, Device = new Device() };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

        _cameraService.PersonDetection(hardwareId, "John Doe");
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareFeatureNotSupportedException))]
    public void PersonDetection_ShouldThrowException_WhenCameraDoesNotSupportPersonDetection()
    {
        var hardwareId = Guid.NewGuid();

        var securityCam = new SecurityCam
        {
            CamSupportedActions = [CamSupportedActions.MotionDetection],
        };

        var hardware = new Hardware
        {
            Device = securityCam
        };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

        _cameraService.PersonDetection(hardwareId, null);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareNotCompatibleException))]
    public void MotionDetection_ShouldThrowException_WhenHardwareIsNotSecurityCam()
    {
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Id = hardwareId, Device = new Device() };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

        _cameraService.MotionDetection(hardwareId);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareFeatureNotSupportedException))]
    public void MotionDetection_ShouldThrowException_WhenCameraDoesNotSupportMotionDetection()
    {
        var hardwareId = Guid.NewGuid();

        var securityCam = new SecurityCam
        {
            CamSupportedActions = [CamSupportedActions.PersonDetection]
        };

        var hardware = new Hardware
        {
            Device = securityCam
        };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);

        _cameraService.MotionDetection(hardwareId);
    }

    [TestMethod]
    public void MotionDetection_ShouldReturnNotifications_WhenDetectionIsSuccessful()
    {
        var hardwareId = Guid.NewGuid();

        var securityCam = new SecurityCam
        {
            CamSupportedActions = [CamSupportedActions.MotionDetection]
        };

        var hardware = new Hardware
        {
            Device = securityCam
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

        _mockNotificationService.Setup(repo => repo.AddNotification(hardwareId, It.IsAny<string>()))
            .Returns(expectedNotifications);

        var result = _cameraService.MotionDetection(hardwareId);

        Assert.AreEqual(expectedNotifications, result);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareFeatureNotSupportedException))]
    public void AddCamera_ShouldThrowArgumentException_WhenInvalidSupportedActionIsProvided()
    {
        var deviceRequest = new DeviceCamRequest
        {
            Name = "Camera 1",
            ModelNumber = "Model123",
            Description = "Test camera",
            Photos = new[] { "photo1.jpg", "photo2.jpg" }.ToList(),
            UseTypes = new[] { "Indoor", "Outdoor" }.ToList(),
            SupportedActions = new[] { "PersonDetection", "InvalidAction" }.ToList()
        };

        var mockedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "Test",
            Surname = "User",
            Email = "test@example.com",
            Roles = [Role.CompanyOwner]
        };

        _cameraService.AddCamera(deviceRequest, mockedUser);
    }

    [TestMethod]
    [ExpectedException(typeof(HardwareFeatureNotSupportedException))]
    public void AddCamera_ShouldThrowArgumentException_WhenInvalidUseTypeIsProvided()
    {
        var deviceRequest = new DeviceCamRequest
        {
            Name = "Camera 1",
            ModelNumber = "Model123",
            Description = "Test camera",
            Photos = new[] { "photo1.jpg", "photo2.jpg" }.ToList(),
            UseTypes = new[] { "Indoor", "InvalidUseType" }.ToList(),
            SupportedActions = new[] { "PersonDetection", "MotionDetection" }.ToList()
        };

        var mockedUser = new User
        {
            Id = Guid.NewGuid(),
            Name = "Test",
            Surname = "User",
            Email = "test@example.com",
            Roles = [Role.CompanyOwner]
        };

        _cameraService.AddCamera(deviceRequest, mockedUser);
    }

    [TestMethod]
    public void PersonDetection_ShouldAddNotification_WhenUserDetectedIsProvided()
    {
        var hardwareId = Guid.NewGuid();

        var securityCam = new SecurityCam
        {
            CamSupportedActions = [CamSupportedActions.PersonDetection]
        };

        var hardware = new Hardware
        {
            Device = securityCam
        };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);
        var user1 = new User { Id = Guid.NewGuid(), Name = "John Doe", Email = "johndoe@example.com" };

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
        var expectedNotifications = new List<NotificationResponse> { new NotificationResponse(notification1) };
        _mockNotificationService.Setup(repo => repo.AddNotification(hardwareId, It.IsAny<string>()))
            .Returns(expectedNotifications);

        var result = _cameraService.PersonDetection(hardwareId, "John Doe");

        Assert.AreEqual(expectedNotifications, result);
        _mockNotificationService.Verify(repo => repo.AddNotification(hardwareId, "Camera Alert: Person detected: John Doe"), Times.Once);
    }

    [TestMethod]
    public void PersonDetection_ShouldAddNotification_WhenNoUserDetectedIsProvided()
    {
        var hardwareId = Guid.NewGuid();

        var securityCam = new SecurityCam
        {
            CamSupportedActions = [CamSupportedActions.PersonDetection]
        };

        var hardware = new Hardware
        {
            Device = securityCam
        };

        _mockDeviceService.Setup(repo => repo.GetHardwareById(hardwareId)).Returns(hardware);
        var user1 = new User { Id = Guid.NewGuid(), Name = "John Doe", Email = "johndoe@example.com" };

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

        var expectedNotifications = new List<NotificationResponse> { new NotificationResponse(notification1) };
        _mockNotificationService.Setup(repo => repo.AddNotification(hardwareId, It.IsAny<string>()))
            .Returns(expectedNotifications);

        var result = _cameraService.PersonDetection(hardwareId, null);

        Assert.AreEqual(expectedNotifications, result);
        _mockNotificationService.Verify(repo => repo.AddNotification(hardwareId, "Camera Alert: Person detected"), Times.Once);
    }
}
