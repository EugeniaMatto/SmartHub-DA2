using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.BussinesLogicTests;

[TestClass]
public class AdministratorServiceTest
{
    private AdministratorService? _administratorService;
    private Mock<IUserService>? _mockUserService;
    private Mock<IPermissionService>? _mockPermissionService;

    [TestInitialize]
    public void Setup()
    {
        _mockUserService = new Mock<IUserService>();
        _mockPermissionService = new Mock<IPermissionService>();
        _administratorService = new AdministratorService(_mockUserService.Object, _mockPermissionService.Object);
    }

    [TestMethod]
    public void CreateAdminAccount_ShouldCreateAdminAndAssignPermissions()
    {
        var newAdmin = new AdministratorRequest
        {
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Password = "securepassword"
        };

        User createdAdmin = null;

        _mockUserService.Setup(repo => repo.AddAccount(It.IsAny<User>()))
            .Callback<User>(user => createdAdmin = user);

        _mockPermissionService.Setup(repo => repo.AddUserPermission(It.IsAny<string>(), It.IsAny<string>()));

        var result = _administratorService.CreateAdminAccount(newAdmin);

        Assert.IsNotNull(createdAdmin);
        Assert.AreEqual(newAdmin.Name, createdAdmin.Name);
        Assert.AreEqual(newAdmin.Surname, createdAdmin.Surname);
        Assert.AreEqual(newAdmin.Email, createdAdmin.Email);
        Assert.AreEqual(newAdmin.Password, createdAdmin.Password);
        var expectedRoles = new List<Role> { Role.Administrator };
        CollectionAssert.AreEquivalent(expectedRoles, result.Roles);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void DeleteAdminAccount_ShouldThrowException_WhenAdministratorNotFound()
    {
        var accountId = Guid.NewGuid();
        _mockUserService.Setup(repo => repo.GetById(accountId.ToString())).Returns((User)null);

        _administratorService.DeleteAdminAccount(accountId);
    }

    [TestMethod]
    public void DeleteAdminAccount_ShouldDeleteAdmin_WhenRoleIsAdministrator()
    {
        var accountId = Guid.NewGuid();
        var admin = new User
        {
            Id = accountId,
            Roles = [Role.Administrator]
        };

        _mockUserService.Setup(repo => repo.GetById(accountId.ToString())).Returns(admin);

        _administratorService.DeleteAdminAccount(accountId);

        _mockUserService.Verify(repo => repo.DeleteAccount(admin, Role.Administrator), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void CreateAdminAccount_ShouldThrowException_WhenPermissionAssignmentFails()
    {
        var newAdmin = new AdministratorRequest
        {
            Name = "Jane",
            Surname = "Doe",
            Email = "jane.doe@example.com",
            Password = "strongpassword"
        };

        _mockUserService.Setup(repo => repo.AddAccount(It.IsAny<User>()));

        _mockPermissionService.Setup(repo => repo.AddUserPermission(It.IsAny<string>(), newAdmin.Email))
                                 .Throws(new Exception("Permission assignment failed"));

        _administratorService.CreateAdminAccount(newAdmin);
    }
}
