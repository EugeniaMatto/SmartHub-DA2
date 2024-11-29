using System.Linq.Expressions;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class PermissionServiceTests
{
    private Mock<IRepository<Permission>>? _permissionRepositoryMock;
    private Mock<IRepository<User>>? _userRepositoryMock;
    private PermissionService? _permissionService;

    [TestInitialize]
    public void Setup()
    {
        _permissionRepositoryMock = new Mock<IRepository<Permission>>();
        _userRepositoryMock = new Mock<IRepository<User>>();
        _permissionService = new PermissionService(
            _permissionRepositoryMock.Object,
            _userRepositoryMock.Object);
    }

    [TestMethod]
    public void UserHasPermission_ShouldThrow()
    {
        var permissionName = "TestPermission";
        var userEmail = "test@example.com";
        var exception = Assert.ThrowsException<NotFoundException>(() => _permissionService!.UserHasPermission(userEmail, permissionName));
    }

    [TestMethod]
    public void AddPermission_ShouldAddPermission_WhenNotExists()
    {
        var permissionName = "TestPermission";

        _permissionRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Permission, bool>>>())).Returns((Permission)null);

        _permissionService!.AddPermission(permissionName);

        _permissionRepositoryMock.Verify(repo => repo.Add(It.Is<Permission>(p => p.Name == permissionName)), Times.Once);
    }

    [TestMethod]
    public void AddPermission_ShouldNotAddPermission_WhenExists()
    {
        var permissionName = "TestPermission";
        var existingPermission = new Permission(permissionName);

        _permissionRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Permission, bool>>>())).Returns(existingPermission);

        _permissionService!.AddPermission(permissionName);

        _permissionRepositoryMock.Verify(repo => repo.Add(It.IsAny<Permission>()), Times.Once);
    }

    [TestMethod]
    public void AddUserPermission_ShouldAddPermissionToUser_WhenUserDoesNotHaveIt()
    {
        var permissionName = "TestPermission";
        var userEmail = "test@example.com";
        var user = new User { Email = userEmail, Permissions = [] };
        var permission = new Permission(permissionName);

        _userRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<User, bool>>>(), It.IsAny<Expression<Func<User, object>>[]>())).Returns(user);
        _permissionRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Permission, bool>>>())).Returns(permission);

        _permissionService!.AddUserPermission(permissionName, userEmail);

        _userRepositoryMock.Verify(repo => repo.Update(It.Is<User>(u => u.Email == userEmail && u.HasPermission(permission))), Times.Once);
    }

    [TestMethod]
    public void UserHasPermission_ShouldReturnTrue_WhenUserHasPermission()
    {
        var userEmail = "test@example.com";
        var permissionName = "TestPermission";
        var permission = new Permission(permissionName);
        var user = new User { Email = userEmail, Permissions = [permission] };

        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>(), It.IsAny<Expression<Func<User, object>>[]>())).Returns(user);
        _permissionRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Permission, bool>>>())).Returns(permission);

        var result = _permissionService!.UserHasPermission(userEmail, permissionName);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void UserHasPermission_ShouldReturnFalse_WhenUserDoesNotHavePermission()
    {
        var userEmail = "test@example.com";
        var permissionName = "TestPermission";
        var permission = new Permission(permissionName);
        var user = new User { Email = userEmail, Permissions = [] };

        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>(), It.IsAny<Expression<Func<User, object>>[]>())).Returns(user);
        _permissionRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Permission, bool>>>())).Returns(permission);

        var result = _permissionService!.UserHasPermission(userEmail, permissionName);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void AddNeutralPermissions_ShouldAddAllNeutralPermissions_WhenCalled()
    {
        var userEmail = "test@example.com";
        var user = new User { Email = userEmail, Permissions = [] };

        _userRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<User, bool>>>(), It.IsAny<Expression<Func<User, object>>[]>())).Returns(user);

        _permissionService!.AddNeutralPermissions(user);

        var expectedPermissions = new[]
        {
        "getnotifications-notification",
        "open-windowsensor",
        "close-windowsensor",
        "motiondetection-camera",
        "persondetection-camera",
        "getdevices-devices",
        "getdevicetypes-devicetype",
        "motiondetection-motionsensor",
        "on-smartlamp",
        "off-smartlamp",
        "getpermissions-home",
        "changeprofilephoto-user"
    };

        foreach (var permissionName in expectedPermissions.Distinct())
        {
            var permission = new Permission(permissionName);
            Assert.IsTrue(user.HasPermission(permission), $"User should have permission: {permissionName}");
        }

        _userRepositoryMock.Verify(repo => repo.Update(It.Is<User>(u => u.Email == userEmail)), Times.Exactly(expectedPermissions.Distinct().Count()));
    }
}
