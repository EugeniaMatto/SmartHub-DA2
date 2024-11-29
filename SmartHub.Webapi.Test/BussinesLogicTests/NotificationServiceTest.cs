using System.Linq.Expressions;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class NotificationServiceTests
{
    private NotificationService? _service;
    private Mock<IRepository<Notification>>? _mockNotificationRepository;
    private Mock<IRepository<Hardware>>? _mockHardwareRepository;
    private Mock<IRepository<Home>>? _mockHomeRepository;
    private Mock<IRepository<User>>? _mockUserRepository;

    [TestInitialize]
    public void Setup()
    {
        _mockNotificationRepository = new Mock<IRepository<Notification>>();
        _mockHardwareRepository = new Mock<IRepository<Hardware>>();
        _mockHomeRepository = new Mock<IRepository<Home>>();
        _mockUserRepository = new Mock<IRepository<User>>();
        _service = new NotificationService(
            _mockNotificationRepository.Object,
            _mockHardwareRepository.Object,
            _mockHomeRepository.Object,
            _mockUserRepository.Object);
    }

    [TestMethod]
    public void GetNotifications_WithUserId_ReturnsNotifications()
    {
        var userId = Guid.NewGuid();
        var notifications = new List<Notification>
        {
            new Notification { Id = Guid.NewGuid(), Event = "Test Event", Seen = false, UserId = userId }
        };

        _mockNotificationRepository.Setup(nr => nr.GetAll(It.IsAny<Expression<Func<Notification, bool>>>(), It.IsAny<Expression<Func<Notification, object>>>()))
            .Returns(notifications.AsQueryable());

        var result = _service.GetNotifications(userId, null);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public void GetNotifications_WithoutUserId_ReturnsNotifications()
    {
        var notifications = new List<Notification>
        {
            new Notification { Id = Guid.NewGuid(), Event = "Test Event", Seen = false }
        };

        _mockNotificationRepository.Setup(nr => nr.GetAll(It.IsAny<Expression<Func<Notification, bool>>>(), It.IsAny<Expression<Func<Notification, object>>>()))
            .Returns(notifications.AsQueryable());

        var result = _service.GetNotifications(null, null);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public void GetNotifications_NoNotifications_ReturnsEmptyList()
    {
        var userId = Guid.NewGuid();

        _mockNotificationRepository.Setup(nr => nr.GetAll(It.IsAny<Expression<Func<Notification, bool>>>(), It.IsAny<Expression<Func<Notification, object>>>()))
            .Returns(new List<Notification>().AsQueryable());

        var result = _service.GetNotifications(userId, null);

        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void AddNotification_HardwareOffline_ThrowsException()
    {
        var hardwareId = Guid.NewGuid();
        var descripcion = "Test Notification";
        var hardware = new Hardware { Id = hardwareId, Online = false };

        _mockHardwareRepository.Setup(repo => repo.Get(It.IsAny<Expression<Func<Hardware, bool>>>()))
            .Returns(hardware);

        var exception = Assert.ThrowsException<HardwareFeatureNotSupportedException>(() => _service.AddNotification(hardwareId, descripcion));
    }

    [TestMethod]
    public void AddNotification_HardwareOnline_AddsNotificationsForAllMembers()
    {
        var hardwareId = Guid.NewGuid();
        var descripcion = "Test Notification";

        var hardware = new Hardware { Id = hardwareId, Online = true, HomeId = Guid.NewGuid() };
        var homeId = hardware.HomeId;
        var user1Id = Guid.NewGuid();
        var user2Id = Guid.NewGuid();

        var home = new Home
        {
            Id = homeId,
            NotificationMembers =
        [
            new NotificationMember { UserId = user1Id }, // User 1
            new NotificationMember { UserId = user2Id } // User 2
        ]
        };

        var user1 = new User { Id = user1Id, Email = "user1@example.com" };
        var user2 = new User { Id = user2Id, Email = "user2@example.com" };

        _mockHardwareRepository.Setup(repo => repo.Get(h => h.Id == hardwareId)).Returns(hardware);
        _mockHomeRepository.Setup(repo => repo.Get(h => h.Id == hardware.HomeId, h => h.NotificationMembers))
            .Returns(home);

        _mockUserRepository.Setup(repo => repo.Get(It.Is<Expression<Func<User, bool>>>(expr => expr.Compile().Invoke(user1))))
            .Returns(user1);
        _mockUserRepository.Setup(repo => repo.Get(It.Is<Expression<Func<User, bool>>>(expr => expr.Compile().Invoke(user2))))
            .Returns(user2);

        var result = _service.AddNotification(hardwareId, descripcion);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);

        _mockNotificationRepository.Verify(repo => repo.Add(It.IsAny<Notification>()), Times.Exactly(2));
    }
}
