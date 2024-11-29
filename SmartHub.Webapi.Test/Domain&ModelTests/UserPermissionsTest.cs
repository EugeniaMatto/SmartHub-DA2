using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain_ModelTests;
[TestClass]
public class UserPermissionsTest
{
    [TestMethod]
    public void PermissionId_ShouldGetAndSetValue()
    {
        var userPermissions = new UserPermissions();
        var permissionId = Guid.NewGuid();
        userPermissions.PermissionId = permissionId;
        Assert.AreEqual(permissionId, userPermissions.PermissionId);
    }

    [TestMethod]
    public void UserId_ShouldGetAndSetValue()
    {
        var userPermissions = new UserPermissions();
        var userId = Guid.NewGuid();
        userPermissions.UserId = userId;
        Assert.AreEqual(userId, userPermissions.UserId);
    }

    [TestMethod]
    public void User_ShouldGetAndSetValue()
    {
        var userPermissions = new UserPermissions();
        var user = new User { Id = Guid.NewGuid(), Name = "TestUser" };
        userPermissions.User = user;
        Assert.AreEqual(user, userPermissions.User);
        Assert.AreEqual("TestUser", userPermissions.User.Name);
    }

    [TestMethod]
    public void Permission_ShouldGetAndSetValue()
    {
        var userPermissions = new UserPermissions();
        var permission = new Permission { Id = Guid.NewGuid(), Name = "TestPermission" };
        userPermissions.Permission = permission;
        Assert.AreEqual(permission, userPermissions.Permission);
        Assert.AreEqual("TestPermission", userPermissions.Permission.Name);
    }
}
