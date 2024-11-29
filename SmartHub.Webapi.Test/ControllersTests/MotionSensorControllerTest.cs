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
public class MotionSensorControllerTests
{
    private Mock<IMotionSensorService>? _mockSensorService;
    private Mock<HttpContext>? _mockHttpContext;
    private MotionSensorController? _motionSensorController;
    private User? _mockUser;

    [TestInitialize]
    public void SetUp()
    {
        _mockSensorService = new Mock<IMotionSensorService>();
        _mockHttpContext = new Mock<HttpContext>();
        _motionSensorController = new MotionSensorController(_mockSensorService.Object);

        _mockUser = new User { Email = "user@example.com" };
        _motionSensorController.ControllerContext = new ControllerContext()
        {
            HttpContext = _mockHttpContext.Object
        };

        _mockHttpContext.Setup(c => c.Items[Item.UserLogged]).Returns(_mockUser);
    }

    [TestMethod]
    public void AddMotionSensor_ShouldReturnOk_WhenModelIsValid()
    {
        var deviceRequest = new DeviceRequest
        {
            Name = "MotionSensor1",
            ModelNumber = "54321",
            Description = "A motion sensor",
            Photos = new[] { "motionphoto1.jpg", "motionphoto2.jpg" }.ToList()
        };

        var sensorId = Guid.NewGuid();

        _mockSensorService.Setup(s => s.AddMotionSensor(deviceRequest, It.IsAny<User>()))
            .Returns(sensorId);

        var userLoggedMock = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com"
        };

        var httpContextMock = new Mock<HttpContext>();
        httpContextMock.Setup(c => c.Items[Item.UserLogged]).Returns(userLoggedMock);

        _motionSensorController.ControllerContext = new ControllerContext
        {
            HttpContext = httpContextMock.Object
        };

        var result = _motionSensorController.AddMotionSensor(deviceRequest) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var resultId = result.Value.GetType().GetProperty("id")?.GetValue(result.Value);
        Assert.IsNotNull(resultId);
        Assert.AreEqual(sensorId, resultId);
    }

    [TestMethod]
    public void AddMotionSensor_ShouldThrowValidationException_WhenModelIsInvalid()
    {
        var deviceRequest = new DeviceRequest
        {
            Name = string.Empty,
            ModelNumber = string.Empty,
            Description = string.Empty,
            Photos = new[] { string.Empty }.ToList()
        };
        _motionSensorController.ModelState.AddModelError("Name", "Name is required");

        Assert.ThrowsException<ValidationException>(() => _motionSensorController.AddMotionSensor(deviceRequest));
    }

    [TestMethod]
    public void MotionDetection_ShouldReturnOk_WithNotifications()
    {
        var hardwareId = Guid.NewGuid();
        var notifications = new List<Notification>
        {
            new Notification
            {
                Id = Guid.NewGuid(),
                Event = "Motion detected",
                Seen = false,
                UserEmail = "user@example.com",
                User = new User
                {
                    Email = "user@example.com"
                }
            }
        };

        _mockSensorService.Setup(service => service.MotionDetection(hardwareId))
            .Returns(notifications.Select(n => new NotificationResponse(n)).ToList());

        var result = _motionSensorController.MotionDetection(hardwareId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var response = result.Value.GetType().GetProperty("notifications")?.GetValue(result.Value) as IEnumerable<object>;
        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Count());
    }
}
