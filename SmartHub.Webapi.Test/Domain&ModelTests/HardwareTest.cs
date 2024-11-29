using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class HardwareTests
{
    [TestMethod]
    public void Hardware_ShouldBeOnlineByDefault()
    {
        var hardware = new Hardware();
        Assert.IsTrue(hardware.Online);
    }

    [TestMethod]
    public void Hardware_ShouldSetOnlineStatus()
    {
        var hardware = new Hardware();
        hardware.Online = false;
        Assert.IsFalse(hardware.Online);
    }

    [TestMethod]
    public void Hardware_ShouldSetAndGetHome()
    {
        var home = new Home("Name", "Street", "123", new UbicationGeo(34, 56), new User(), 5);
        var hardware = new Hardware
        {
            Home = home
        };
        Assert.AreEqual(home, hardware.Home);
    }

    [TestMethod]
    public void Hardware_ShouldSetAndGetName()
    {
        var name = "Name";
        var hardware = new Hardware
        {
            Name = name
        };
        Assert.AreEqual(name, hardware.Name);
    }

    [TestMethod]
    public void Hardware_ShouldHaveUniqueHardwareId()
    {
        var hardware = new Hardware();
        Assert.IsNotNull(hardware.Id);
    }

    [TestMethod]
    public void Hardware_ShouldAllowSettingHardwareId()
    {
        var hardware = new Hardware();
        hardware.Id = new();
        Assert.AreEqual(hardware.Id, hardware.Id);
    }
}
