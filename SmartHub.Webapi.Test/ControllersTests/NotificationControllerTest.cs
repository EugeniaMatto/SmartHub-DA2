using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Model.Response;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class NotificationsControllerTest
{
    private NotificationController? _controller;
    private Mock<INotificationService>? _mockNotificationService;

    [TestInitialize]
    public void Setup()
    {
        _mockNotificationService = new Mock<INotificationService>();
        _controller = new NotificationController(_mockNotificationService.Object);
    }

    [TestMethod]
    public void GetNotifications_WithUserId_ReturnsOkResult()
    {
        var userId = Guid.NewGuid();
        var notifications = new List<Notification>
        {
            new Notification { Id = Guid.NewGuid(), Event = "Test Event", Seen = false, UserId = userId }
        };
        _mockNotificationService.Setup(ns => ns.GetNotifications(userId, null)).Returns(notifications.ConvertAll(u => new NotificationResponse(u)));

        var result = _controller.GetNotifications(userId, null);
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void GetNotifications_WithoutUserId_ReturnsOkResult()
    {
        var notifications = new List<Notification>
        {
            new Notification { Id = Guid.NewGuid(), Event = "Test Event", Seen = false }
        };
        _mockNotificationService.Setup(ns => ns.GetNotifications(null, null)).Returns(notifications.ConvertAll(u => new NotificationResponse(u)));

        var result = _controller.GetNotifications(null, null);

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void GetNotifications_NoNotifications_ReturnsOkResultWithEmptyList()
    {
        var userId = Guid.NewGuid();
        _mockNotificationService.Setup(ns => ns.GetNotifications(userId, null)).Returns([]);

        var result = _controller.GetNotifications(userId, null);

        Assert.IsNotNull(result);
    }
}
