using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class DeviceTests
{
    [TestMethod]
    public void ShouldSetPropertiesCorrectly()
    {
        var expectedName = "Test Device";
        var expectedType = DeviceType.WindowSensor;
        var id = Guid.NewGuid();
        var device = new Device
        {
            Name = expectedName,
            Type = expectedType,
            CompanyId = id,
        };
        Assert.AreEqual(expectedName, device.Name);
        Assert.AreEqual(expectedType, device.Type);
        Assert.AreEqual(device.CompanyId, id);
    }

    [TestMethod]
    public void ShouldSetDefaultValues()
    {
        var device = new Device();
        Assert.IsNotNull(device.Id);
        Assert.AreEqual(string.Empty, device.Name);
        Assert.AreNotEqual(default, device.CreatedAt);
    }

    [TestMethod]
    public void ShouldReturnCorrectToString()
    {
        var device = new Device { Name = "Test Device" };
        var result = device.ToString();
        Assert.AreEqual("Device Name: Test Device", result);
    }

    [TestMethod]
    public void ShouldGenerateDifferentIdsForNewDevices()
    {
        var device1 = new Device();
        var device2 = new Device();
        Assert.AreNotEqual(device1.Id, device2.Id);
    }
}
