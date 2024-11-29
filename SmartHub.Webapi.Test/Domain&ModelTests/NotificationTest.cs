using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;
[TestClass]
public class NotificationTests
{
    [TestMethod]
    public void Notification_ShouldHaveSeenFalseByDefault()
    {
        var notification = new Notification();
        Assert.IsFalse(notification.Seen);
    }

    [TestMethod]
    public void Notification_ShouldSetSeenStatus()
    {
        var notification = new Notification();
        notification.Seen = true;
        Assert.IsTrue(notification.Seen);
    }

    [TestMethod]
    public void Notification_ShouldSetAndGetDevice()
    {
        var device = new Hardware();
        var notification = new Notification
        {
            Hardware = device,
            HardwareId = device.Id
        };
        Assert.AreEqual(device, notification.Hardware);
        Assert.AreEqual(device.Id, notification.HardwareId);
    }

    [TestMethod]
    public void Notification_ShouldSetAndGetUser()
    {
        var user = new User();
        var notification = new Notification
        {
            User = user,
            UserId = user.Id
        };
        Assert.AreEqual(user, notification.User);
        Assert.AreEqual(user.Id, notification.UserId);
    }

    [TestMethod]
    public void Notification_ShouldAllowSettingEvent()
    {
        var notification = new Notification();
        notification.Event = "Device Overheated";
        Assert.AreEqual("Device Overheated", notification.Event);
    }
}
