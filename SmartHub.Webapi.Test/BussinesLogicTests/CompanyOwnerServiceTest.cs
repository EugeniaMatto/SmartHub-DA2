using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.BussinesLogicTests;

[TestClass]
public class CompanyOwnerServiceTest
{
    private CompanyOwnerService? _companyOwnerService;
    private Mock<IUserService>? _mockUserService;
    private Mock<IPermissionService>? _mockPermissionService;

    [TestInitialize]
    public void Setup()
    {
        _mockUserService = new Mock<IUserService>();
        _mockPermissionService = new Mock<IPermissionService>();
        _companyOwnerService = new CompanyOwnerService(_mockUserService.Object, _mockPermissionService.Object);
    }

    [TestMethod]
    public void CreateCompanyOwnerAccount_ShouldCreateAccountAndAssignPermissions_WhenDataIsValid()
    {
        var newAccount = new CompanyOwnerRequest
        {
            Name = "Jane",
            Surname = "Doe",
            Email = "jane.doe@example.com",
            Password = "securepassword"
        };

        User createdAccount = null;

        _mockUserService.Setup(repo => repo.AddAccount(It.IsAny<User>()))
            .Callback<User>(user => createdAccount = user);

        var mockPermissionRepository = new Mock<IPermissionService>();
        _companyOwnerService = new CompanyOwnerService(_mockUserService.Object, mockPermissionRepository.Object);

        var result = _companyOwnerService.CreateCompanyOwnerAccount(newAccount);
        Assert.IsNotNull(result);
        Assert.AreEqual(newAccount.Name, result.Name);
        Assert.AreEqual(newAccount.Surname, result.Surname);
        Assert.AreEqual(newAccount.Email, result.Email);
        Assert.AreEqual(newAccount.Password, result.Password);
        var expectedRoles = new List<Role> { Role.CompanyOwner };
        CollectionAssert.AreEquivalent(expectedRoles, result.Roles);

        mockPermissionRepository.Verify(repo => repo.AddNeutralPermissions(It.IsAny<User>()), Times.Once);
        mockPermissionRepository.Verify(repo => repo.AddUserPermission("createcompany-companies", newAccount.Email), Times.Once);
        mockPermissionRepository.Verify(repo => repo.AddUserPermission("addsensor-windowsensor", newAccount.Email), Times.Once);
        mockPermissionRepository.Verify(repo => repo.AddUserPermission("addmotionsensor-motionsensor", newAccount.Email), Times.Once);
        mockPermissionRepository.Verify(repo => repo.AddUserPermission("addsmartlamp-smartlamp", newAccount.Email), Times.Once);
        mockPermissionRepository.Verify(repo => repo.AddUserPermission("addcamera-camera", newAccount.Email), Times.Once);
        mockPermissionRepository.Verify(repo => repo.AddUserPermission("addhomeownerpermission-homeowner", newAccount.Email), Times.Once);
    }

    [TestMethod]
    public void CreateCompanyOwnerAccount_ShouldGenerateNonEmptyGuid_WhenAccountIsCreated()
    {
        var newAccount = new CompanyOwnerRequest
        {
            Name = "Jane",
            Surname = "Doe",
            Email = "jane.doe@example.com",
            Password = "securepassword"
        };

        var result = _companyOwnerService.CreateCompanyOwnerAccount(newAccount);

        Assert.AreNotEqual(Guid.Empty, result.Id);
    }

    [TestMethod]
    public void CreateCompanyOwnerAccount_ShouldAssignNeutralPermissions_WhenAccountIsCreated()
    {
        var newAccount = new CompanyOwnerRequest
        {
            Name = "Jane",
            Surname = "Doe",
            Email = "jane.doe@example.com",
            Password = "securepassword"
        };

        var mockService = new Mock<IPermissionService>();
        _companyOwnerService = new CompanyOwnerService(_mockUserService.Object, _mockPermissionService.Object);

        var result = _companyOwnerService.CreateCompanyOwnerAccount(newAccount);

        _mockPermissionService.Verify(repo => repo.AddNeutralPermissions(It.IsAny<User>()), Times.Once);
    }
}
