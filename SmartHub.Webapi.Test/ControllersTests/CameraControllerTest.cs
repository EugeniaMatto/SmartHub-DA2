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
public class CameraControllerTest
{
    private CameraController? _cameraController;
    private Mock<ICameraService>? _cameraServiceMock;
    private User _mockedUser = new User();

    [TestInitialize]
    public void Setup()
    {
        _cameraServiceMock = new Mock<ICameraService>();
        _cameraController = new CameraController(_cameraServiceMock.Object);

        _mockedUser = new User
        {
            Id = Guid.NewGuid(),
            Roles = [Role.CompanyOwner]
        };
    }

    [TestMethod]
    public void AddCamera_ShouldReturnOk_WhenCameraIsAddedSuccessfully()
    {
        var deviceRequest = new DeviceCamRequest
        {
            Name = "Camera 1",
            ModelNumber = "Model123",
            Description = "Test camera",
            Photos = new[] { "photo1.jpg", "photo2.jpg" }.ToList(),
            UseTypes = new[] { "Indoor", "Outdoor" }.ToList(),
            SupportedActions = new[] { "Action1", "Action2" }.ToList()
        };

        var cameraId = Guid.NewGuid();

        _cameraServiceMock.Setup(service => service.AddCamera(It.IsAny<DeviceCamRequest>(), It.IsAny<User>()))
            .Returns(cameraId);

        var userLoggedMock = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com"
        };

        var httpContextMock = new Mock<HttpContext>();
        httpContextMock.Setup(c => c.Items[Item.UserLogged]).Returns(userLoggedMock);

        _cameraController.ControllerContext = new ControllerContext
        {
            HttpContext = httpContextMock.Object
        };

        var result = _cameraController.AddCamera(deviceRequest) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(cameraId, result.Value.GetType().GetProperty("id")?.GetValue(result.Value));
    }

    [TestMethod]
    public void AddCamera_ShouldReturnBadRequest_WhenModelIsInvalid()
    {
        _cameraController.ModelState.AddModelError("Name", "Required");

        var deviceRequest = new DeviceCamRequest
        {
            Name = string.Empty,
            ModelNumber = "Model123",
            Description = "Test camera",
            Photos = new[] { "photo1.jpg", "photo2.jpg" }.ToList(),
            UseTypes = new[] { "Indoor", "Outdoor" }.ToList(),
            SupportedActions = new[] { "Action1", "Action2" }.ToList()
        };

        var exception = Assert.ThrowsException<ValidationException>(() => _cameraController.AddCamera(deviceRequest));
    }

    [TestMethod]
    public void PersonDetection_ShouldReturnOk_WhenNoUserDetectionProvided()
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

        _cameraServiceMock.Setup(service => service.PersonDetection(hardwareId, null))
            .Returns(notifications.Select(n => new NotificationResponse(n)).ToList());

        var result = _cameraController.PersonDetection(hardwareId, null) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        var response = result.Value.GetType().GetProperty("notifications")?.GetValue(result.Value) as IEnumerable<object>;
        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Count());
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

        _cameraServiceMock.Setup(service => service.MotionDetection(hardwareId))
            .Returns(notifications.Select(n => new NotificationResponse(n)).ToList());

        var result = _cameraController.MotionDetection(hardwareId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        var response = result.Value.GetType().GetProperty("notifications")?.GetValue(result.Value) as IEnumerable<object>;
        Assert.IsNotNull(response);
        Assert.AreEqual(1, response.Count());
    }

    [TestMethod]
    public void MotionDetection_ShouldHandleException_WhenServiceThrowsError()
    {
        var hardwareId = Guid.NewGuid();

        _cameraServiceMock.Setup(service => service.MotionDetection(hardwareId))
            .Throws(new Exception("Internal error"));

        try
        {
            _cameraController.MotionDetection(hardwareId);
        }
        catch (Exception ex)
        {
            Assert.AreEqual("Internal error", ex.Message);
        }
    }

    [TestMethod]
    public void PersonDetection_ShouldHandleException_WhenServiceThrowsError()
    {
        var hardwareId = Guid.NewGuid();

        _cameraServiceMock.Setup(service => service.PersonDetection(hardwareId, It.IsAny<string>()))
            .Throws(new Exception("Internal error"));

        try
        {
            _cameraController.PersonDetection(hardwareId);
        }
        catch (Exception ex)
        {
            Assert.AreEqual("Internal error", ex.Message);
        }
    }
}
