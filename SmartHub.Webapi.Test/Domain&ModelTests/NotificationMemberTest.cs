using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class NotificationMemberTests
{
    [TestMethod]
    public void Id_SetAndGet_ShouldReturnExpectedValue()
    {
        var notificationMember = new NotificationMember();
        var id = Guid.NewGuid();
        notificationMember.Id = id;
        Assert.AreEqual(id, notificationMember.Id);
    }

    [TestMethod]
    public void HomeId_SetAndGet_ShouldReturnExpectedValue()
    {
        var notificationMember = new NotificationMember();
        var homeId = Guid.NewGuid();
        notificationMember.HomeId = homeId;
        Assert.AreEqual(homeId, notificationMember.HomeId);
    }

    [TestMethod]
    public void Home_SetAndGet_ShouldReturnExpectedValue()
    {
        var notificationMember = new NotificationMember();
        var home = new Home();
        notificationMember.Home = home;
        Assert.AreEqual(home, notificationMember.Home);
    }

    [TestMethod]
    public void UserId_SetAndGet_ShouldReturnExpectedValue()
    {
        var notificationMember = new NotificationMember();
        var userId = Guid.NewGuid();
        notificationMember.UserId = userId;
        Assert.AreEqual(userId, notificationMember.UserId);
    }

    [TestMethod]
    public void User_SetAndGet_ShouldReturnExpectedValue()
    {
        var notificationMember = new NotificationMember();
        var user = new User();
        notificationMember.User = user;
        Assert.AreEqual(user, notificationMember.User);
    }
}
