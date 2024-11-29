using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class PermissionTests
{
    [TestMethod]
    public void Constructor_ShouldInitializeNameWithEmptyString()
    {
        var permission = new Permission();
        Assert.AreEqual(string.Empty, permission.Name);
    }

    [TestMethod]
    public void Constructor_WithParameter_ShouldSetName()
    {
        var permission = new Permission("create-home");
        Assert.AreEqual("create-home", permission.Name);
    }

    [TestMethod]
    public void Id_SetAndGet_ShouldReturnExpectedValue()
    {
        var permission = new Permission();
        var id = Guid.NewGuid();
        permission.Id = id;
        Assert.AreEqual(id, permission.Id);
    }

    [TestMethod]
    public void ToString_ShouldReturnName()
    {
        var permission = new Permission("create-home");
        Assert.AreEqual("create-home", permission.ToString());
    }
}
