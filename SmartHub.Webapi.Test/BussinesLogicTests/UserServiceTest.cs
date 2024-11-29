using System.Linq.Expressions;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class UserServiceTests
{
    private UserService? _service;
    private Mock<IRepository<User>>? _mockUserRepository;
    private Mock<IRepository<UserHomePermission>>? _mockUserHomeRepository;
    private Mock<IHomeService>? _mockHomeService;

    [TestInitialize]
    public void Setup()
    {
        _mockUserRepository = new Mock<IRepository<User>>();
        _mockUserHomeRepository = new Mock<IRepository<UserHomePermission>>();
        _mockHomeService = new Mock<IHomeService>();
        _service = new UserService(_mockUserRepository.Object, _mockUserHomeRepository.Object, _mockHomeService.Object);
    }

    [TestMethod]
    public void Login_ValidCredentials_ReturnsUser()
    {
        var username = "test@example.com";
        var password = "password123";
        var user = new User { Email = username, Password = password };

        _mockUserRepository.Setup(repo => repo.Get(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns(user);

        var result = _service.Login(username, password);

        Assert.IsNotNull(result);
        Assert.AreEqual(username, result.Email);
    }

    [TestMethod]
    public void Login_InvalidCredentials_ThrowsValidationException()
    {
        var username = "test@example.com";
        var password = "wrongpassword";

        _mockUserRepository.Setup(repo => repo.Get(It.IsAny<Expression<Func<User, bool>>>()))
            .Throws(new InvalidOperationException());

        var exception = Assert.ThrowsException<InvalidValueException>(() => _service.Login(username, password));
    }

    [TestMethod]
    public void AddAccount_UserAlreadyExists_ThrowsException()
    {
        var newUser = new User { Email = "test@example.com" };
        _mockUserRepository.Setup(repo => repo.Exist(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns(true);

        var exception = Assert.ThrowsException<AlreadyExistsException>(() => _service.AddAccount(newUser));
    }

    [TestMethod]
    public void AddAccount_NewUser_AddsUserAndReturnsId()
    {
        var newUser = new User { Email = "test@example.com", Id = Guid.NewGuid() };
        _mockUserRepository.Setup(repo => repo.Exist(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns(false);
        _mockUserRepository.Setup(repo => repo.Add(newUser));

        var result = _service.AddAccount(newUser);

        Assert.AreEqual(newUser.Id, result);
        _mockUserRepository.Verify(repo => repo.Add(newUser), Times.Once);
    }

    [TestMethod]
    public void DeleteAccount_ValidUser_RemovesUser()
    {
        var user = new User { Id = Guid.NewGuid(), Roles = [Role.Administrator] };

        var result = _service.DeleteAccount(user, Role.Administrator);

        Assert.IsTrue(result);
        _mockUserRepository.Verify(repo => repo.Remove(user), Times.Once);
    }

    [TestMethod]
    public void DeleteAccount_ValidUser_RemovesRole()
    {
        var user = new User { Id = Guid.NewGuid(), Roles = [Role.Administrator, Role.HomeOwner] };

        var result = _service.DeleteAccount(user, Role.Administrator);

        Assert.IsTrue(result);
        _mockUserRepository.Verify(repo => repo.Remove(user), Times.Never);
        _mockUserRepository.Verify(repo => repo.Update(user), Times.Once);
    }

    [TestMethod]
    public void GetById_ValidUserId_ReturnsUser()
    {
        var userId = Guid.NewGuid().ToString();
        var user = new User { Id = Guid.Parse(userId) };

        _mockUserRepository.Setup(repo => repo.Get(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns(user);

        var result = _service.GetById(userId);

        Assert.IsNotNull(result);
        Assert.AreEqual(user.Id, result.Id);
    }

    [TestMethod]
    public void GetById_InvalidUserIdFormat_ThrowsArgumentException()
    {
        var invalidUserId = "invalid-guid";

        var exception = Assert.ThrowsException<InvalidValueException>(() => _service.GetById(invalidUserId));
    }

    [TestMethod]
    public void GetHomes_UserHasNoHomes_ReturnsEmptyList()
    {
        var user = new User { Id = Guid.NewGuid() };
        _mockUserRepository.Setup(repo => repo.Get(
            u => u.Id == user.Id,
            u => u.OwnedHomes,
            u => u.HomePermissions))
            .Returns(user);

        var result = _service.GetHomes(user);

        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void GetHomes_UserHasOwnedHome_ReturnsHomeWithOwnerRole()
    {
        var home = new Home { Id = Guid.NewGuid(), Name = "My Home" };
        var user = new User
        {
            Id = Guid.NewGuid(),
            OwnedHomes = [home]
        };

        _mockUserRepository.Setup(repo => repo.Get(
            u => u.Id == user.Id,
            u => u.OwnedHomes,
            u => u.HomePermissions))
            .Returns(user);
        _mockHomeService.Setup(service => service.GetHomeResponseById(home.Id))
            .Returns(new HomeResponse(
                home.Id,
                home.Name,
                string.Empty,
                string.Empty,
                new UbicationGeo(0, 0),
                string.Empty,
                [],
                0));
        var result = _service.GetHomes(user);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(home.Id, result[0].Home.Id);
        Assert.AreEqual("Owner", result[0].Role);
        Assert.AreEqual(5, result[0].Permissions.Count);
    }

    [TestMethod]
    public void GetHomes_UserHasHomePermission_ReturnsHomeWithMemberRole()
    {
        var home = new Home
        {
            Id = Guid.NewGuid(),
            Name = "Shared Home",
            Street = "Main St",
            StreetNumber = "123",
            Ubication = new UbicationGeo(0, 0),
            MaxMembers = 5,
            Rooms = ["Room 1", "Room 2"],
            Owner = new User { Email = "owner@example.com" }
        };

        var homePermission = new UserHomePermission
        {
            HomeId = home.Id,
            Home = home,
            Permissions = [HomePermission.ListDevices]
        };

        var user = new User
        {
            Id = Guid.NewGuid(),
            OwnedHomes = [],
            HomePermissions = [homePermission]
        };

        _mockUserRepository.Setup(repo => repo.Get(
            u => u.Id == user.Id,
            u => u.OwnedHomes,
            u => u.HomePermissions))
            .Returns(user);

        _mockUserHomeRepository.Setup(repo => repo.Get(
            uhp => uhp.Id == homePermission.Id,
            uhp => uhp.Home))
            .Returns(homePermission);

        _mockHomeService.Setup(service => service.GetHomeResponseById(home.Id))
            .Returns(new HomeResponse(
                    home.Id,
                    home.Name,
                    home.Street,
                    home.StreetNumber,
                    home.Ubication,
                    home.Owner.Email,
                    home.Rooms,
                    home.MaxMembers));

        var result = _service.GetHomes(user);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(home.Id, result[0].Home.Id);
        Assert.AreEqual(home.Name, result[0].Home.Name);
        Assert.AreEqual("Member", result[0].Role);
        Assert.AreEqual(1, result[0].Permissions.Count);
        Assert.AreEqual(HomePermission.ListDevices.ToString(), result[0].Permissions[0]);
    }

    [TestMethod]
    public void GetHomes_UserHasHomePermissionWithNoPermissions_ReturnsHomeWithMemberRole()
    {
        var home = new Home { Id = Guid.NewGuid(), Name = "Unknown Home" };
        var homePermission = new UserHomePermission { HomeId = home.Id, Home = home, Permissions = [] };
        var user = new User { OwnedHomes = [], HomePermissions = [homePermission] };

        _mockUserRepository.Setup(repo => repo.Get(
            u => u.Id == user.Id,
            u => u.OwnedHomes,
            u => u.HomePermissions))
            .Returns(user);
        _mockUserHomeRepository.Setup(repo => repo.Get(
                    uhp => uhp.Id == homePermission.Id,
                    uhp => uhp.Home))
            .Returns(homePermission);
        _mockHomeService.Setup(service => service.GetHomeResponseById(home.Id))
           .Returns(new HomeResponse(
               home.Id,
               home.Name,
               string.Empty,
               string.Empty,
               new UbicationGeo(0, 0),
               string.Empty,
               [],
               0));

        var result = _service.GetHomes(user);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(home.Id, result[0].Home.Id);
        Assert.AreEqual(home.Name, result[0].Home.Name);
        Assert.AreEqual("Member", result[0].Role);
        Assert.IsNotNull(result[0].Permissions);
        Assert.AreEqual(0, result[0].Permissions.Count);
    }

    [TestMethod]
    public void ChangeProfilePhoto_ValidPhoto_UpdatesUserProfilePhoto()
    {
        var user = new User { Name = "John", Surname = "Doe", Email = "john@example.com", ProfilePhoto = "oldPhoto.jpg", Roles = [Role.HomeOwner] };
        var newPhoto = "newPhoto.jpg";

        _mockUserRepository.Setup(repo => repo.Update(It.IsAny<User>()));

        var result = _service.ChangeProfilePhoto(user, newPhoto);

        Assert.IsNotNull(result);
        Assert.AreEqual(user.Id, result.Id);
        Assert.AreEqual(user.Name, result.Name);
        Assert.AreEqual(user.Surname, result.Surname);
        Assert.AreEqual(user.Email, result.Email);
        Assert.AreEqual(newPhoto, result.ProfilePhoto);
        Assert.IsTrue(DateTime.Now > user.CreatedAt);
        Assert.AreEqual(user.Roles.Count, 1);
    }

    [TestMethod]
    public void GetEmails_ValidRole_ReturnsCorrectEmails()
    {
        var role = Role.HomeOwner;
        var user1 = new User { Id = Guid.NewGuid(), Email = "user1@example.com", Roles = [Role.HomeOwner] };
        var user2 = new User { Id = Guid.NewGuid(), Email = "user2@example.com", Roles = [Role.HomeOwner, Role.Administrator] };
        var user3 = new User { Id = Guid.NewGuid(), Email = "user3@example.com", Roles = [Role.Administrator] };

        var users = new List<User> { user1, user2, user3 }.AsQueryable();

        _mockUserRepository.Setup(repo => repo.GetAll(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns(users.Where(u => u.Roles.Contains(role)));

        var result = _service.GetEmails(role);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
        Assert.AreEqual("user1@example.com", result[0]);
        Assert.AreEqual("user2@example.com", result[1]);
    }
}
