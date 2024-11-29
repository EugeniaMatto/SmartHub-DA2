using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class UserHomePermissionTests
{
    [TestMethod]
    public void ShouldSetAndGetUser()
    {
        var home = new Home();
        var user = new User { Name = "John", Surname = "Doe", Email = "john.doe@example.com", Password = "pass" };
        var userHomePermission = new UserHomePermission { User = user, Home = home };
        Assert.AreEqual(user, userHomePermission.User);
        Assert.AreEqual(home, userHomePermission.Home);
    }

    [TestMethod]
    public void ShouldSetAndGetPermissions()
    {
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices, HomePermission.ListDevices };
        var userHomePermission = new UserHomePermission { Permissions = permissions };
        CollectionAssert.AreEqual(permissions.ToList(), userHomePermission.Permissions.ToList());
    }

    [TestMethod]
    public void ShouldAddPermission()
    {
        var userHomePermission = new UserHomePermission();
        userHomePermission.Permissions.Add(HomePermission.AssociateDevices);
        Assert.IsTrue(userHomePermission.Permissions.Contains(HomePermission.AssociateDevices));
    }

    [TestMethod]
    public void ShouldRemovePermission()
    {
        var userHomePermission = new UserHomePermission();
        userHomePermission.Permissions.Add(HomePermission.AssociateDevices);
        userHomePermission.Permissions.Remove(HomePermission.AssociateDevices);
        Assert.IsFalse(userHomePermission.Permissions.Contains(HomePermission.AssociateDevices));
    }
}
