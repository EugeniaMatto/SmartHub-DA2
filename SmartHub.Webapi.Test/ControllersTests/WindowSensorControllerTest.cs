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
public class SensorControllerTests
{
    private Mock<IWindowSensorService>? _mockSensorService;
    private Mock<HttpContext>? _mockHttpContext;
    private WindowSensorController? _sensorController;
    private User? _mockUser;

    [TestInitialize]
    public void SetUp()
    {
        _mockSensorService = new Mock<IWindowSensorService>();
        _mockHttpContext = new Mock<HttpContext>();
        _sensorController = new WindowSensorController(_mockSensorService.Object);

        _mockUser = new User { Email = "user@example.com" };
        _sensorController.ControllerContext = new ControllerContext()
        {
            HttpContext = _mockHttpContext.Object
        };

        _mockHttpContext.Setup(c => c.Items[Item.UserLogged]).Returns(_mockUser);
    }

    [TestMethod]
    public void AddSensor_ShouldReturnOk_WhenModelIsValid()
    {
        var deviceRequest = new DeviceRequest
        {
            Name = "Sensor1",
            ModelNumber = "12345",
            Description = "A temperature sensor",
            Photos = new[] { "photo1.jpg", "photo2.jpg" }.ToList()
        };

        var sensorId = Guid.NewGuid();

        _mockSensorService.Setup(s => s.AddSensor(deviceRequest, It.IsAny<User>()))
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

        _sensorController.ControllerContext = new ControllerContext
        {
            HttpContext = httpContextMock.Object
        };

        var result = _sensorController.AddSensor(deviceRequest) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var resultId = result.Value.GetType().GetProperty("id")?.GetValue(result.Value);
        Assert.IsNotNull(resultId);
        Assert.AreEqual(sensorId, resultId);
    }

    [TestMethod]
    public void AddSensor_ShouldThrowValidationException_WhenModelIsInvalid()
    {
        var deviceRequest = new DeviceRequest
        {
            Name = string.Empty,
            ModelNumber = string.Empty,
            Description = string.Empty,
            Photos = new[] { string.Empty }.ToList()
        };
        _sensorController.ModelState.AddModelError("Name", "Name is required");

        Assert.ThrowsException<ValidationException>(() => _sensorController.AddSensor(deviceRequest));
    }

    [TestMethod]
    public void Open_ShouldReturnOk_WithNotifications()
    {
        var hardwareId = Guid.NewGuid();
        var notifications = new List<Notification>
    {
        new Notification
        {
            Id = Guid.NewGuid(),
            Event = "Sensor opened",
            Seen = false,
            UserEmail = "user@example.com",
            User = new User
            {
                Email = "user@example.com"
            }
        }
    };

        _mockSensorService.Setup(service => service.Open(hardwareId))
            .Returns(notifications.Select(n => new NotificationResponse(n)).ToList());

        var result = _sensorController.Open(hardwareId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var response = result.Value.GetType().GetProperty("notifications")?.GetValue(result.Value) as IEnumerable<object>;
        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Count());
    }

    [TestMethod]
    public void Close_ShouldReturnOk_WithNotifications()
    {
        var hardwareId = Guid.NewGuid();
        var notifications = new List<Notification>
    {
        new Notification
        {
            Id = Guid.NewGuid(),
            Event = "Sensor closed",
            Seen = false,
            UserEmail = "user@example.com",
            User = new User
            {
                Email = "user@example.com"
            }
        }
    };

        _mockSensorService.Setup(service => service.Close(hardwareId))
            .Returns(notifications.Select(n => new NotificationResponse(n)).ToList());

        var result = _sensorController.Close(hardwareId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var response = result.Value.GetType().GetProperty("notifications")?.GetValue(result.Value) as IEnumerable<object>;
        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Count());
    }
}
