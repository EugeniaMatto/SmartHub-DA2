using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.BussinesLogicTests;

[TestClass]
public class HomeOwnerServiceTest
{
    private HomeOwnerService? _homeOwnerService;
    private Mock<IUserService>? _mockUserRepository;
    private Mock<IPermissionService>? _mockPermissionRepository;

    [TestInitialize]
    public void Setup()
    {
        _mockUserRepository = new Mock<IUserService>();
        _mockPermissionRepository = new Mock<IPermissionService>();
        _homeOwnerService = new HomeOwnerService(_mockUserRepository.Object, _mockPermissionRepository.Object);
    }

    [TestMethod]
    public void CreateHomeOwnerAccount_ShouldCreateAccount_WhenDataIsValid()
    {
        var newHomeOwner = new HomeOwnerRequest
        {
            Name = "Alice",
            Surname = "Smith",
            Email = "alice.smith@example.com",
            Password = "securepassword",
            ProfilePhoto = "http://example.com/photo.jpg"
        };

        User createdAccount = null;

        _mockUserRepository.Setup(repo => repo.AddAccount(It.IsAny<User>()))
            .Callback<User>(user =>
            {
                createdAccount = user;
                user.Id = Guid.NewGuid();
            });

        var result = _homeOwnerService.CreateHomeOwnerAccount(newHomeOwner);

        Assert.IsNotNull(result);
        Assert.AreNotEqual(Guid.Empty, result.Id);
        Assert.AreEqual(newHomeOwner.Name, result.Name);
        Assert.AreEqual(newHomeOwner.Surname, result.Surname);
        Assert.AreEqual(newHomeOwner.Email, result.Email);
        Assert.AreEqual(newHomeOwner.Password, result.Password);
        Assert.AreEqual(newHomeOwner.ProfilePhoto, result.ProfilePhoto);
        var expectedRoles = new List<Role> { Role.HomeOwner };
        CollectionAssert.AreEquivalent(expectedRoles, result.Roles);

        _mockPermissionRepository.Verify(repo => repo.AddNeutralPermissions(It.IsAny<User>()), Times.Once);
        _mockPermissionRepository.Verify(repo => repo.AddUserPermission("add-home", newHomeOwner.Email), Times.Once);
        _mockPermissionRepository.Verify(repo => repo.AddUserPermission("addmember-members", newHomeOwner.Email), Times.Once);
        _mockPermissionRepository.Verify(repo => repo.AddUserPermission("adddevice-home", newHomeOwner.Email), Times.Once);
        _mockPermissionRepository.Verify(repo => repo.AddUserPermission("getmembers-members", newHomeOwner.Email), Times.Once);
        _mockPermissionRepository.Verify(repo => repo.AddUserPermission("getdevices-home", newHomeOwner.Email), Times.Once);
        _mockPermissionRepository.Verify(repo => repo.AddUserPermission("addnotificationmembers-members", newHomeOwner.Email), Times.Once);
        _mockPermissionRepository.Verify(repo => repo.AddUserPermission("updatenamedevice-home", newHomeOwner.Email), Times.Once);
    }

    [TestMethod]
    public void GetUserEmails_ShouldReturnEmailsOfHomeOwners()
    {
        var homeOwnerEmail1 = "user1@example.com";
        var homeOwnerEmail2 = "user2@example.com";

        _mockUserRepository.Setup(repo => repo.GetEmails(Role.HomeOwner))
            .Returns([homeOwnerEmail1, homeOwnerEmail2]);

        var result = _homeOwnerService.GetUserEmails();

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
        Assert.AreEqual(homeOwnerEmail1, result[0]);
        Assert.AreEqual(homeOwnerEmail2, result[1]);
    }
}
