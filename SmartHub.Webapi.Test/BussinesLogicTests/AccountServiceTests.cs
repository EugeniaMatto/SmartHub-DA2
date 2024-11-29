using Moq;
using SmartHub.BussinesLogic;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.BussinesLogicTests;

[TestClass]
public class AccountServiceTest
{
    private AccountService? _accountService;
    private Mock<IRepository<User>>? _mockUserRepository;

    [TestInitialize]
    public void Setup()
    {
        _mockUserRepository = new Mock<IRepository<User>>();
        _accountService = new AccountService(_mockUserRepository.Object);
    }

    [TestMethod]
    public void GetAll_ShouldReturnAllAccounts_WhenNoFiltersAreApplied()
    {
        var users = GetSampleUsers().AsQueryable();
        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockUserRepository.Setup(repo => repo.GetAll(null)).Returns(users);
        var result = _accountService.GetAll(filter);

        Assert.IsNotNull(result);
        Assert.AreEqual(users.Count(), result.TotalCount);
        Assert.AreEqual(users.Count(), result.Items.Count);
    }

    [TestMethod]
    public void GetAll_ShouldFilterByRole_WhenRoleIsProvided()
    {
        var users = GetSampleUsers().AsQueryable();
        var filter = new AccountFilterRequest
        {
            Role = "Administrator",
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockUserRepository.Setup(repo => repo.GetAll(null, u => u.Roles)).Returns(users);
        var result = _accountService.GetAll(filter);

        Assert.IsNotNull(result);
        Assert.IsTrue(result.Items.All(account => account.Roles.Contains(filter.Role)));
    }

    [TestMethod]
    public void GetAll_ShouldFilterByFullName_WhenFullNameIsProvided()
    {
        var users = GetSampleUsers().AsQueryable();
        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = "John Doe",
            PageNumber = 1,
            PageSize = 10
        };

        _mockUserRepository.Setup(repo => repo.GetAll(null, u => u.Roles)).Returns(users);
        var result = _accountService.GetAll(filter);

        Assert.IsNotNull(result);
        Assert.IsTrue(result.Items.All(account => account.FullName.Contains(filter.FullName, StringComparison.OrdinalIgnoreCase)));
    }

    [TestMethod]
    public void GetAll_ShouldReturnPaginatedResults()
    {
        var users = GetSampleUsers().AsQueryable();
        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 2
        };

        _mockUserRepository.Setup(repo => repo.GetAll(null)).Returns(users);
        var result = _accountService.GetAll(filter);

        Assert.IsNotNull(result);
        Assert.AreEqual(filter.PageSize, result.Items.Count);
        Assert.AreEqual(users.Count(), result.TotalCount);
        Assert.AreEqual(filter.PageNumber, result.PageNumber);
        Assert.AreEqual(filter.PageSize, result.PageSize);
    }

    [TestMethod]
    public void GetAll_ShouldReturnEmptyList_WhenNoAccountsExist()
    {
        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockUserRepository.Setup(repo => repo.GetAll(null, u => u.Roles)).Returns(Enumerable.Empty<User>().AsQueryable());
        var result = _accountService.GetAll(filter);

        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Items.Count);
        Assert.AreEqual(0, result.TotalCount);
    }

    [TestMethod]
    public void GetAll_ShouldReturnAllAccounts_WhenNullOrEmptyFiltersAreProvided()
    {
        var users = GetSampleUsers().AsQueryable();
        var filter = new AccountFilterRequest
        {
            Role = string.Empty,
            FullName = string.Empty,
            PageNumber = 1,
            PageSize = 10
        };

        _mockUserRepository.Setup(repo => repo.GetAll(null)).Returns(users);
        var result = _accountService.GetAll(filter);

        Assert.IsNotNull(result);
        Assert.AreEqual(users.Count(), result.TotalCount);
        Assert.AreEqual(users.Count(), result.Items.Count);
    }

    [TestMethod]
    public void GetAll_ShouldReturnEmptyList_WhenPageNumberExceedsTotalPages()
    {
        var users = GetSampleUsers().AsQueryable();
        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = null,
            PageNumber = 3,
            PageSize = 2
        };

        _mockUserRepository.Setup(repo => repo.GetAll(null)).Returns(users);
        var result = _accountService.GetAll(filter);
        Assert.AreEqual(users.Count(), result.TotalCount);
        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Items.Count);
    }

    private List<User> GetSampleUsers()
    {
        return
        [
            new User { Id = Guid.NewGuid(), Name = "John", Surname = "Doe", Roles = [Role.Administrator], CreatedAt = DateTime.Now },
            new User { Id = Guid.NewGuid(), Name = "Jane", Surname = "Doe", Roles = [Role.HomeOwner], CreatedAt = DateTime.Now },
            new User { Id = Guid.NewGuid(), Name = "Mike", Surname = "Smith", Roles = [Role.CompanyOwner], CreatedAt = DateTime.Now },
            new User { Id = Guid.NewGuid(), Name = "Sara", Surname = "Connor", Roles = [Role.HomeOwner, Role.Administrator], CreatedAt = DateTime.Now }
        ];
    }
}
