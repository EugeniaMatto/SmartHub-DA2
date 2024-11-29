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
public class SmartLampControllerTest
{
    private SmartLampController? _smartLampController;
    private Mock<ISmartLampService>? _smartLampServiceMock;
    private User _mockedUser = new User();

    [TestInitialize]
    public void Setup()
    {
        _smartLampServiceMock = new Mock<ISmartLampService>();
        _smartLampController = new SmartLampController(_smartLampServiceMock.Object);

        _mockedUser = new User
        {
            Id = Guid.NewGuid(),
            Roles = [Role.CompanyOwner]
        };
    }

    [TestMethod]
    public void AddSmartLamp_ShouldReturnOk_WhenSmartLampIsAddedSuccessfully()
    {
        var deviceRequest = new DeviceRequest
        {
            Name = "Smart Lamp 1",
            ModelNumber = "SL123",
            Description = "Test smart lamp",
            Photos = new[] { "lamp1.jpg", "lamp2.jpg" }.ToList()
        };

        var lampId = Guid.NewGuid();

        _smartLampServiceMock.Setup(service => service.AddSmartLamp(It.IsAny<DeviceRequest>(), It.IsAny<User>()))
            .Returns(lampId);

        var userLoggedMock = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com"
        };

        var httpContextMock = new Mock<HttpContext>();
        httpContextMock.Setup(c => c.Items[Item.UserLogged]).Returns(userLoggedMock);

        _smartLampController.ControllerContext = new ControllerContext
        {
            HttpContext = httpContextMock.Object
        };

        var result = _smartLampController.AddSmartLamp(deviceRequest) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(lampId, result.Value.GetType().GetProperty("id")?.GetValue(result.Value));
    }

    [TestMethod]
    public void AddSmartLamp_ShouldReturnBadRequest_WhenModelIsInvalid()
    {
        _smartLampController.ModelState.AddModelError("Name", "Required");

        var deviceRequest = new DeviceRequest
        {
            Name = string.Empty,
            ModelNumber = "SL123",
            Description = "Test smart lamp",
            Photos = new[] { "lamp1.jpg", "lamp2.jpg" }.ToList()
        };
        var exception = Assert.ThrowsException<ValidationException>(() => _smartLampController.AddSmartLamp(deviceRequest));
    }

    [TestMethod]
    public void On_ShouldReturnOk_WithNotifications()
    {
        var hardwareId = Guid.NewGuid();
        var notifications = new List<Notification>
        {
            new Notification
            {
                Id = Guid.NewGuid(),
                Event = "Lamp turned on",
                Seen = false,
                UserEmail = "user@example.com",
                User = new User
                {
                    Email = "user@example.com"
                }
            }
        };

        _smartLampServiceMock.Setup(service => service.On(hardwareId))
            .Returns(notifications.Select(n => new NotificationResponse(n)).ToList());

        var result = _smartLampController.On(hardwareId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        var response = result.Value.GetType().GetProperty("notifications")?.GetValue(result.Value) as IEnumerable<object>;
        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Count());
    }

    [TestMethod]
    public void Off_ShouldReturnOk_WithNotifications()
    {
        var hardwareId = Guid.NewGuid();
        var notifications = new List<Notification>
        {
            new Notification
            {
                Id = Guid.NewGuid(),
                Event = "Lamp turned off",
                Seen = false,
                UserEmail = "user@example.com",
                User = new User
                {
                    Email = "user@example.com"
                }
            }
        };

        _smartLampServiceMock.Setup(service => service.Off(hardwareId))
            .Returns(notifications.Select(n => new NotificationResponse(n)).ToList());

        var result = _smartLampController.Off(hardwareId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        var response = result.Value.GetType().GetProperty("notifications")?.GetValue(result.Value) as IEnumerable<object>;
        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Count());
    }

    [TestMethod]
    public void On_ShouldHandleException_WhenServiceThrowsError()
    {
        var hardwareId = Guid.NewGuid();

        _smartLampServiceMock.Setup(service => service.On(hardwareId))
            .Throws(new Exception("Internal error"));

        try
        {
            _smartLampController.On(hardwareId);
        }
        catch (Exception ex)
        {
            Assert.AreEqual("Internal error", ex.Message);
        }
    }

    [TestMethod]
    public void Off_ShouldHandleException_WhenServiceThrowsError()
    {
        var hardwareId = Guid.NewGuid();

        _smartLampServiceMock.Setup(service => service.Off(hardwareId))
            .Throws(new Exception("Internal error"));

        try
        {
            _smartLampController.Off(hardwareId);
        }
        catch (Exception ex)
        {
            Assert.AreEqual("Internal error", ex.Message);
        }
    }
}
