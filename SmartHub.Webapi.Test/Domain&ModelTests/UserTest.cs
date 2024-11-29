using SmartHub.Domain;

namespace SmartHub.Webapi.Test;
[TestClass]
public class CompanyRepositoryTest
{
    [TestMethod]
    public void Name_SetAndGet_ShouldReturnExpectedValue()
    {
        var user = new User();
        user.Name = "Juan";
        Assert.AreEqual("Juan", user.Name);
    }

    [TestMethod]
    public void Surname_SetAndGet_ShouldReturnExpectedValue()
    {
        var user = new User();
        user.Surname = "Pérez";
        Assert.AreEqual("Pérez", user.Surname);
    }

    [TestMethod]
    public void Email_SetAndGet_ShouldReturnExpectedValue()
    {
        var user = new User();
        user.Email = "juanperez@example.com";
        Assert.AreEqual("juanperez@example.com", user.Email);
    }

    [TestMethod]
    public void Password_SetAndGet_ShouldReturnExpectedValue()
    {
        var user = new User();
        user.Password = "Password123";
        Assert.AreEqual("Password123", user.Password);
    }

    [TestMethod]
    public void HasPermission_ShouldReturnTrue_WhenPermissionExists()
    {
        var user = new User();
        var permission = new Permission("create-home");
        user.Permissions.Add(permission);
        Assert.IsTrue(user.HasPermission(permission));
    }

    [TestMethod]
    public void HasPermission_ShouldReturnFalse_WhenPermissionDoesNotExist()
    {
        var user = new User();
        var permission = new Permission("create-home");
        Assert.IsFalse(user.HasPermission(permission));
    }

    [TestMethod]
    public void HasPermission_ShouldReturnTrue_WhenPermissionExists_HasPermission()
    {
        var user = new User();
        var permission = new Permission { Name = "ViewDashboard" };
        user.Permissions.Add(permission);

        var result = user.HasPermission(permission);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void HasPermission_ShouldReturnFalse_WhenPermissionDoesNotExist_UserHasPermission()
    {
        var user = new User();
        var permission = new Permission { Name = "EditSettings" };

        var result = user.HasPermission(permission);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Permissions_ShouldReturnEmptyList_WhenPermissionsJsonIsEmpty()
    {
        var userHomePermission = new UserHomePermission();
        var permissions = userHomePermission.Permissions;

        Assert.IsNotNull(permissions);
        Assert.AreEqual(0, permissions.Count);
    }

    [TestMethod]
    public void RemovePermission_ShouldRemovePermission_WhenPermissionExists()
    {
        var user = new User();
        var permission = new Permission("add-home");
        user.Permissions.Add(permission);

        Assert.IsTrue(user.HasPermission(permission));

        user.RemovePermission(permission);

        Assert.IsFalse(user.HasPermission(permission));
    }

    [TestMethod]
    public void RemovePermission_ShouldDoNothing_WhenPermissionDoesNotExist()
    {
        var user = new User();
        var permission = new Permission("add-home");

        user.RemovePermission(permission);

        Assert.AreEqual(0, user.Permissions.Count);
    }

    [TestMethod]
    public void OwnedHomes_SetAndGet_ShouldReturnExpectedValue()
    {
        var guid = Guid.NewGuid();
        var guid2 = Guid.NewGuid();
        var user = new User();
        var ownedHomes = new List<Home>
        {
        new Home { Id = guid },
        new Home { Id = guid2 }
    };

        user.OwnedHomes = ownedHomes;

        Assert.AreEqual(2, user.OwnedHomes.Count);
        Assert.AreEqual(guid, user.OwnedHomes[0].Id);
        Assert.AreEqual(guid2, user.OwnedHomes[1].Id);
    }
}
