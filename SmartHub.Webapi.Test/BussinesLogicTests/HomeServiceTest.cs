using System.Linq.Expressions;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.BussinesLogicTests;

[TestClass]
public class HomeServiceTests
{
    private Mock<IRepository<Home>>? _homeRepositoryMock;
    private Mock<IRepository<UserHomePermission>>? _userHomePermissionsRepositoryMock;
    private Mock<IRepository<NotificationMember>>? _notificationMembersRepositoryMock;
    private Mock<IRepository<User>>? _userRepositoryMock;
    private Mock<IRepository<Device>>? _deviceRepositoryMock;
    private HomeService? _homeService;
    private DeviceService? _deviceService;
    private Mock<IRepository<Company>>? _companyRepositoryMock;
    private Mock<IRepository<Hardware>>? _hardwareRepositoryMock;

    [TestInitialize]
    public void Setup()
    {
        _homeRepositoryMock = new Mock<IRepository<Home>>();
        _userHomePermissionsRepositoryMock = new Mock<IRepository<UserHomePermission>>();
        _notificationMembersRepositoryMock = new Mock<IRepository<NotificationMember>>();
        _userRepositoryMock = new Mock<IRepository<User>>();
        _deviceRepositoryMock = new Mock<IRepository<Device>>();
        _companyRepositoryMock = new Mock<IRepository<Company>>();
        _hardwareRepositoryMock = new Mock<IRepository<Hardware>>();

        _deviceService = new DeviceService(_deviceRepositoryMock.Object, _companyRepositoryMock.Object, _hardwareRepositoryMock.Object, null, null);
        _homeService = new HomeService(
            _homeRepositoryMock.Object,
            _userHomePermissionsRepositoryMock.Object,
            _notificationMembersRepositoryMock.Object,
            _userRepositoryMock.Object,
            _deviceRepositoryMock.Object,
            _deviceService);
    }

    [TestMethod]
    public void AddHome_ShouldReturnHomeId()
    {
        var newHome = new HomeRequest { Street = "Main St", StreetNumber = "123", MaxMembers = 5, Ubication = new UbicationGeoRequest { Lat = 10, Lon = 20 } };
        var user = new User { Id = Guid.NewGuid() };
        var homeId = Guid.NewGuid();
        _homeRepositoryMock.Setup(repo => repo.Add(It.IsAny<Home>())).Callback<Home>(home => home.Id = homeId);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var result = _homeService.AddHome(newHome, user);

        Assert.AreEqual(homeId.ToString(), result);
    }

    [TestMethod]
    public void AddHardware_ShouldThrowException_WhenUserHasNoPermission()
    {
        var homeId = Guid.NewGuid();
        var request = new RequestHardware { DeviceId = Guid.NewGuid().ToString() };

        var user = new User { Id = Guid.NewGuid() };

        var owner = new User { Id = Guid.NewGuid() };

        var home = new Home { Id = homeId, Owner = owner, Members = [] };

        var userHomePermission = new UserHomePermission
        {
            User = user,
            UserId = user.Id,
            HomeId = homeId,
            Permissions = [HomePermission.ListDevices]
        };

        home.Members.Add(userHomePermission);

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        var exception = Assert.ThrowsException<HomePermissionException>(() => _homeService.AddHardware(homeId.ToString(), request, user));
    }

    [TestMethod]
    public void AddRooms_ShouldThrowException_WhenUserHasNoPermission()
    {
        var homeId = Guid.NewGuid();

        var user = new User { Id = Guid.NewGuid() };

        var owner = new User { Id = Guid.NewGuid() };

        var home = new Home { Id = homeId, Owner = owner, Members = [] };

        var userHomePermission = new UserHomePermission
        {
            User = user,
            UserId = user.Id,
            HomeId = homeId,
            Permissions = [HomePermission.ListDevices]
        };

        home.Members.Add(userHomePermission);

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        var exception = Assert.ThrowsException<HomePermissionException>(() => _homeService.AddRooms(homeId.ToString(), ["Living"], user));
    }

    [TestMethod]
    public void AddRooms_ShouldAddRooms_WhenRoomsDoNotExist()
    {
        var homeId = Guid.NewGuid().ToString();
        var newRooms = new List<string> { "Living Room", "Bedroom" };

        var user = new User { Id = Guid.NewGuid() };
        var home = new Home { Id = Guid.NewGuid(), Rooms = [], OwnerId = user.Id, Owner = user };
        var userHomePermission = new UserHomePermission
        {
            User = user,
            UserId = user.Id,
            HomeId = home.Id,
            Permissions = [HomePermission.AddRooms]
        };

        home.Members.Add(userHomePermission);

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner)).Returns(home);
        _homeService.AddRooms(homeId, newRooms, user);

        Assert.AreEqual(2, home.Rooms.Count);
        Assert.IsTrue(home.Rooms.Contains("Living Room"));
        Assert.IsTrue(home.Rooms.Contains("Bedroom"));
        _homeRepositoryMock.Verify(repo => repo.Update(home), Times.Once);
    }

    [TestMethod]
    public void AddRooms_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var homeId = Guid.NewGuid().ToString();
        var newRooms = new List<string> { "Living Room", "Bedroom" };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);
        var user = new User { Id = Guid.NewGuid() };
        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddRooms(homeId, newRooms, user));
    }

    [TestMethod]
    public void AddRooms_ShouldThrowException_WhenRoomAlreadyExists()
    {
        var homeId = Guid.NewGuid().ToString();
        var existingRoom = "Living Room";
        var newRooms = new List<string> { existingRoom };

        var user = new User { Id = Guid.NewGuid() };
        var home = new Home { Id = Guid.NewGuid(), Rooms = [existingRoom], OwnerId = user.Id, Owner = user };
        var userHomePermission = new UserHomePermission
        {
            User = user,
            UserId = user.Id,
            HomeId = home.Id,
            Permissions = [HomePermission.AddRooms]
        };

        home.Members.Add(userHomePermission);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                  h => h.Id.ToString() == homeId,
                  h => h.Members,
                  h => h.Owner)).Returns(home);
        var exception = Assert.ThrowsException<AlreadyExistsException>(() => _homeService.AddRooms(homeId, newRooms, user));
    }

    [TestMethod]
    public void AddHardware_ShouldThrowException_WhenRoomNotFoundInHome()
    {
        var homeId = Guid.NewGuid();
        var hardware = new Hardware
        {
            HomeId = homeId,
            DeviceId = Guid.NewGuid(),
            Room = "Living Room"
        };

        var home = new Home
        {
            Id = homeId,
            Rooms = ["Kitchen", "Bedroom"],
            Devices = []
        };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        _deviceRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Device, bool>>>()))
            .Returns(new Device { Id = hardware.DeviceId, Name = "Test Device", Type = DeviceType.WindowSensor });

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddHardware(hardware));
    }

    [TestMethod]
    public void GetDevices_ShouldReturnDevices_WhenUserHasPermission()
    {
        var user = new User { Id = Guid.NewGuid() };
        var owner = new User { Id = Guid.NewGuid() };

        var company = new Company
        {
            Id = Guid.NewGuid(),
            Name = "Test Company"
        };

        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device 1",
            Model = "Model X",
            Type = DeviceType.WindowSensor,
            Photos = ["photo1.jpg", "photo2.jpg"],
            Description = "A sample device",
            Company = company
        };

        var hardware = new Hardware
        {
            Id = Guid.NewGuid(),
            Device = device,
            DeviceId = device.Id,
            Online = true,
            HomeId = Guid.NewGuid()
        };

        var devices = new List<Hardware>
    {
        hardware
    };

        var home = new Home
        {
            Id = Guid.NewGuid(),
            Devices = devices,
            Owner = owner,
            Members =
        [
            new UserHomePermission
            {
                User = user,
                Permissions = [HomePermission.AssociateDevices]
            }

            ]
        };

        var homeId = home.Id.ToString();
        var hardwareId = hardware.Id;

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company)).Returns(hardware);
        var result = _homeService.GetDevices(homeId, user);

        Assert.IsNotNull(result);
        Assert.AreEqual(devices.Count, result.Count);
    }

    [TestMethod]
    public void GetDevices_ShouldReturnDevices_WhenUserHasNotPermission()
    {
        var user = new User { Id = Guid.NewGuid() };
        var owner = new User { Id = Guid.NewGuid() };

        var company = new Company
        {
            Id = Guid.NewGuid(),
            Name = "Test Company"
        };

        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device 1",
            Model = "Model X",
            Type = DeviceType.WindowSensor,
            Photos = ["photo1.jpg", "photo2.jpg"],
            Description = "A sample device",
            Company = company
        };

        var hardware = new Hardware
        {
            Id = Guid.NewGuid(),
            Device = device,
            DeviceId = device.Id,
            Online = true,
            HomeId = Guid.NewGuid()
        };

        var devices = new List<Hardware>
    {
        hardware
    };

        var home = new Home
        {
            Id = Guid.NewGuid(),
            Devices = devices,
            Owner = owner,
            Members =
        [
            new UserHomePermission
            {
                User = user,
                Permissions = [HomePermission.ListDevices]
            }

            ]
        };

        var homeId = home.Id.ToString();
        var hardwareId = hardware.Id;

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner)).Returns(home);

        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company)).Returns(hardware);

        var exception = Assert.ThrowsException<HomePermissionException>(() => _homeService.GetDevices(homeId, user));
    }

    [TestMethod]
    public void AddMember_ShouldThrowException_WhenHomeNotFound()
    {
        var userEmail = "test@example.com";
        var homeId = Guid.NewGuid().ToString();
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddMember(userEmail, homeId, permissions));
    }

    [TestMethod]
    public void AddNotificationMember_ShouldThrowException_WhenHomeNotFound()
    {
        var homeId = Guid.NewGuid().ToString();
        var memberEmail = "test@example.com";

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddNotificationMember(homeId, memberEmail));
    }

    [TestMethod]
    public void UserHasPermission_ShouldReturnTrue_WhenUserIsOwner()
    {
        var userId = Guid.NewGuid();
        var home = new Home { Owner = new User { Id = userId } };
        var homeId = home.Id.ToString();

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        var result = _homeService.UserHasPermission(homeId, userId, HomePermission.AssociateDevices);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void GetHomeById_ShouldReturnHome()
    {
        var homeId = Guid.NewGuid().ToString();
        var home = new Home { Id = Guid.NewGuid() };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        var result = _homeService.GetHomeById(homeId);

        Assert.AreEqual(home, result);
    }

    [TestMethod]
    public void AddHome_ShouldAddHomeAndReturnHomeId()
    {
        var newHome = new HomeRequest { Street = "Main St", StreetNumber = "123", MaxMembers = 5, Ubication = new UbicationGeoRequest { Lat = 10, Lon = 20 } };
        var user = new User { Id = Guid.NewGuid() };
        var homeId = Guid.NewGuid();

        _homeRepositoryMock.Setup(repo => repo.Add(It.IsAny<Home>()))
            .Callback<Home>(home => home.Id = homeId);

        var result = _homeService!.AddHome(newHome, user);

        Assert.AreEqual(homeId.ToString(), result);
        _homeRepositoryMock.Verify(repo => repo.Add(It.IsAny<Home>()), Times.Once);
    }

    [TestMethod]
    public void AddMember_ShouldAddMember_WhenValid()
    {
        var userEmail = "test@example.com";
        var homeId = Guid.NewGuid().ToString();
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices };

        var user = new User { Id = Guid.NewGuid(), Email = userEmail, Roles = [Role.HomeOwner] };
        var home = new Home { Id = Guid.Parse(homeId), MaxMembers = 10 };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Returns(user);

        _homeService!.AddMember(userEmail, homeId, permissions);

        _homeRepositoryMock.Verify(repo => repo.Update(It.IsAny<Home>()), Times.Once);
        _userHomePermissionsRepositoryMock.Verify(repo => repo.Add(It.IsAny<UserHomePermission>()), Times.Once);
    }

    public void AddMember_ShouldMemberNotHomeOwner_WhenValid()
    {
        var userEmail = "test@example.com";
        var homeId = Guid.NewGuid().ToString();
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices };

        var user = new User { Id = Guid.NewGuid(), Email = userEmail };
        var home = new Home { Id = Guid.Parse(homeId), MaxMembers = 10 };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Returns(user);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService!.AddMember(userEmail, homeId, permissions));
        Assert.AreEqual($"User is not Home Owner: {userEmail}", exception.Message);
    }

    [TestMethod]
    public void GetUserHomePermission_ShouldReturnUserHomePermission_WhenExists()
    {
        var homeId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid();
        var home = new Home
        {
            Id = Guid.Parse(homeId),
            Members =
        [
            new UserHomePermission { UserId = userId, Permissions = [HomePermission.AssociateDevices] }
        ]
        };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        var result = _homeService.GetUserHomePermission(homeId, userId);

        Assert.IsNotNull(result);
        Assert.AreEqual(userId, result.UserId);
    }

    [TestMethod]
    public void GetMemberByEmail_ShouldReturnUserHomePermission_WhenUserExists()
    {
        var homeId = Guid.NewGuid().ToString();
        var email = "test@example.com";
        var memberId = Guid.NewGuid();
        var home = new Home
        {
            Id = Guid.NewGuid(),
            Members =
        [
            new UserHomePermission { UserId = memberId, Permissions = [HomePermission.AssociateDevices] }
        ]
        };

        var user = new User { Id = memberId, Email = email };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Returns(user);

        var result = _homeService.GetMemberByEmail(homeId, email);

        Assert.IsNotNull(result);
        Assert.AreEqual(memberId, result.UserId);
    }

    [TestMethod]
    public void GetMemberByEmail_ShouldThrowException_WhenUserNotFound()
    {
        var homeId = Guid.NewGuid().ToString();
        var email = "nonexistent@example.com";
        var home = new Home { Id = Guid.NewGuid(), Members = [] };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Throws(new NotFoundException("Member", email));

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.GetMemberByEmail(homeId, email));
    }

    [TestMethod]
    public void AddHomePermission_ShouldUpdateUserHomePermission()
    {
        var permission = new UserHomePermission
        {
            UserId = Guid.NewGuid(),
            Permissions = [HomePermission.AssociateDevices]
        };

        _homeService.AddHomePermission(permission);

        _userHomePermissionsRepositoryMock.Verify(repo => repo.Update(permission), Times.Once);
    }

    [TestMethod]
    public void GetMembers_ShouldThrowException_WhenHomeNotFound()
    {
        var homeId = Guid.NewGuid().ToString();

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.GetMembers(homeId));
    }

    [TestMethod]
    public void AddHardware_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var hardware = new Hardware { HomeId = Guid.NewGuid() };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddHardware(hardware));
    }

    [TestMethod]
    public void AddHardware_ShouldThrowException_WhenDeviceDoesNotExist()
    {
        var homeId = Guid.NewGuid();
        var hardware = new Hardware { HomeId = homeId, DeviceId = Guid.NewGuid() };

        var home = new Home { Id = homeId, Devices = [] };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns((User)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddHardware(hardware));
    }

    [TestMethod]
    public void AddHardware_WhenDeviceNameIsntNull()
    {
        var homeId = Guid.NewGuid();
        var homeIdStr = homeId.ToString();
        var user = new User() { Id = new() };
        var deviceId = Guid.NewGuid();
        var hardware = new Hardware { HomeId = homeId, DeviceId = deviceId, Name = "name" };
        var request = new RequestHardware() { DeviceId = deviceId.ToString(), Name = "name" };

        var home = new Home { Id = homeId, Devices = [], OwnerId = user.Id, Owner = user };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeIdStr,
                          h => h.Members,
                          h => h.Owner)).Returns(home);

        var except = Assert.ThrowsException<NotFoundException>(() => _homeService.AddHardware(homeId.ToString(), request, user));
    }

    [TestMethod]
    public void AddHardware_ShouldAddHardware_WhenHomeAndDeviceExist_Hardware()
    {
        var homeId = Guid.NewGuid();
        var deviceId = Guid.NewGuid();
        var hardware = new Hardware { HomeId = homeId, DeviceId = deviceId };

        var home = new Home { Id = homeId, Devices = [] };
        var device = new Device { Id = deviceId, Type = DeviceType.SecurityCam };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(h => h.Id == hardware.HomeId, h => h.Devices)).Returns(home);

        _deviceRepositoryMock.Setup(repo => repo.GetOrDefault(d => d.Id == hardware.DeviceId))
            .Returns(device);

        var result = _homeService.AddHardware(hardware);

        Assert.AreEqual(hardware.Id, result);
        _homeRepositoryMock.Verify(repo => repo.Update(home), Times.Once);
    }

    [TestMethod]
    public void AddHardware_ShouldAddHardware_WhenHomeAndDeviceExist_HardwareSmartLamp()
    {
        var homeId = Guid.NewGuid();
        var deviceId = Guid.NewGuid();
        var hardware = new Hardware { HomeId = homeId, DeviceId = deviceId };

        var home = new Home { Id = homeId, Devices = [] };
        var device = new Device { Id = deviceId, Type = DeviceType.SmartLamp };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(h => h.Id == hardware.HomeId, h => h.Devices)).Returns(home);

        _deviceRepositoryMock.Setup(repo => repo.GetOrDefault(d => d.Id == hardware.DeviceId))
            .Returns(device);

        var result = _homeService.AddHardware(hardware);

        Assert.AreEqual(hardware.Id, result);
        _homeRepositoryMock.Verify(repo => repo.Update(home), Times.Once);
    }

    [TestMethod]
    public void AddHardware_ShouldAddHardware_WhenHomeAndDeviceExist_HardwareWindowSensor()
    {
        var homeId = Guid.NewGuid();
        var deviceId = Guid.NewGuid();
        var hardware = new Hardware { HomeId = homeId, DeviceId = deviceId };

        var home = new Home { Id = homeId, Devices = [] };
        var device = new Device { Id = deviceId, Type = DeviceType.WindowSensor };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(h => h.Id == hardware.HomeId, h => h.Devices)).Returns(home);

        _deviceRepositoryMock.Setup(repo => repo.GetOrDefault(d => d.Id == hardware.DeviceId))
            .Returns(device);

        var result = _homeService.AddHardware(hardware);

        Assert.AreEqual(hardware.Id, result);
        _homeRepositoryMock.Verify(repo => repo.Update(home), Times.Once);
    }

    [TestMethod]
    public void GetMembers_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var homeId = Guid.NewGuid().ToString();

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.GetMembers(homeId));
    }

    [TestMethod]
    public void AddMember_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var userEmail = "test@example.com";
        var homeId = Guid.NewGuid().ToString();
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddMember(userEmail, homeId, permissions));
    }

    [TestMethod]
    public void AddMember_ShouldThrowInvalidOperationException_WhenMaxMembersReached()
    {
        var userEmail = "test@example.com";
        var homeId = Guid.NewGuid().ToString();
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices };

        var user = new User { Id = Guid.NewGuid(), Roles = [Role.HomeOwner] };
        var home = new Home
        {
            Id = Guid.Parse(homeId),
            MaxMembers = 1,
            Members =
        [
            new UserHomePermission { UserId = user.Id }
        ]
        };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns(user);

        var exception = Assert.ThrowsException<AlreadyExistsException>(() =>
            _homeService.AddMember(userEmail, homeId, permissions));
    }

    [TestMethod]
    public void AddMember_ShouldThrowHomeNotFoundException_WhenUserDoesNotExist()
    {
        var userEmail = "test@example.com";
        var homeId = Guid.NewGuid().ToString();
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices };

        var home = new Home { Id = Guid.Parse(homeId), MaxMembers = 10 };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Returns((User)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.AddMember(userEmail, homeId, permissions));
    }

    [TestMethod]
    public void AddMember_ShouldThrowInvalidOperationException_WhenUserAlreadyMember()
    {
        var userEmail = "test@example.com";
        var homeId = Guid.NewGuid().ToString();
        var permissions = new List<HomePermission> { HomePermission.AssociateDevices };

        var userId = Guid.NewGuid();
        var user = new User { Id = userId, Email = userEmail, Roles = [Role.HomeOwner, Role.Administrator] };
        var home = new Home { Id = Guid.Parse(homeId), MaxMembers = 10, Members = [new UserHomePermission { UserId = userId }] };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Returns(user);

        var exception = Assert.ThrowsException<AlreadyExistsException>(() => _homeService.AddMember(userEmail, homeId, permissions));
    }

    [TestMethod]
    public void GetMembers_ShouldReturnMembers_WhenHomeExists()
    {
        var homeId = Guid.NewGuid();
        var home = new Home { Id = homeId, Members = [] };

        var user1 = new User { Id = Guid.NewGuid() };
        var user2 = new User { Id = Guid.NewGuid() };

        home.Members.Add(new UserHomePermission { UserId = user1.Id });
        home.Members.Add(new UserHomePermission { UserId = user2.Id });

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);

        var result = _homeService.GetMembers(homeId.ToString());

        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void GetMembers_ShouldReturnMembers_WithNoPermissions_WhenHomeExists()
    {
        var homeId = Guid.NewGuid();
        var home = new Home
        {
            Id = homeId,
            Members =
        [
            new UserHomePermission { UserId = Guid.NewGuid() },
            new UserHomePermission { UserId = Guid.NewGuid() }
        ],
            NotificationMembers = []
        };

        var user1 = new User
        {
            Id = home.Members[0].UserId,
            Name = "User1",
            Surname = "Surname1",
            Email = "user1@example.com",
            HomePermissions = []
        };

        var user2 = new User
        {
            Id = home.Members[1].UserId,
            Name = "User2",
            Surname = "Surname2",
            Email = "user2@example.com",
            HomePermissions = []
        };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
            It.IsAny<Expression<Func<Home, bool>>>(),
            It.IsAny<Expression<Func<Home, object>>[]>()))
            .Returns(home);

        _userRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<Expression<Func<User, bool>>>()))
            .Returns(new List<User> { user1, user2 }.AsQueryable());

        var result = _homeService.GetMembers(homeId.ToString());

        Assert.AreEqual(2, result.Count);
        Assert.AreEqual("User1", result[0].Name);
        Assert.AreEqual("User2", result[1].Name);
        Assert.AreEqual(0, result[0].Permissions.Count);
        Assert.AreEqual(0, result[1].Permissions.Count);
    }

    [TestMethod]
    public void GetHomeById_ShouldThrowArgumentException_WhenHomeIdIsInvalid()
    {
        var invalidHomeId = "invalid-guid";

        var exception = Assert.ThrowsException<InvalidValueException>(() => _homeService.GetHomeById(invalidHomeId));
    }

    [TestMethod]
    public void UserHasPermission_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var invalidHomeId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid();
        var permission = HomePermission.ListDevices;

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                It.IsAny<Expression<Func<Home, bool>>>(),
                null))
            .Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() =>
            _homeService.UserHasPermission(invalidHomeId, userId, permission));
    }

    [TestMethod]
    public void UserHasPermission_ShouldThrowArgumentException_WhenUserIsNotInHomeMembers()
    {
        var homeId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid();
        var permission = HomePermission.ListDevices;
        var owner = new User();

        var home = new Home
        {
            Id = Guid.Parse(homeId),
            Members = [],
            Owner = owner,
            OwnerId = owner.Id
        };
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner))
            .Returns(home);

        var exception = Assert.ThrowsException<NotFoundException>(() =>
            _homeService.UserHasPermission(homeId, userId, permission));
    }

    [TestMethod]
    public void UpdateHardware_UserHasPermission_ShouldUpdateHardwareName()
    {
        var homeId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid();
        var request = new PatchHardwareRequest { HardwareId = Guid.NewGuid().ToString(), Name = "New Hardware Name" };
        var user = new User { Id = userId };
        var hardwareId = Guid.Parse(request.HardwareId);
        var hardware = new Hardware { Id = hardwareId, Name = "Old Hardware Name" };

        var home = new Home
        {
            Id = Guid.Parse(homeId),
            Members = [],
            Owner = user,
            OwnerId = user.Id
        };
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner))
            .Returns(home);
        _userHomePermissionsRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<UserHomePermission, bool>>>()))
            .Returns(new UserHomePermission { Permissions = [HomePermission.ChangeDeviceName] });
        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company))
            .Returns(hardware);
        var result = _homeService.UpdateHardware(homeId, request, user);

        Assert.AreEqual(hardwareId, result);
        Assert.AreEqual("New Hardware Name", hardware.Name);
    }

    [TestMethod]
    public void UpdateHardware_UserDoesNotHavePermission_ShouldThrowException()
    {
        var homeId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid();
        var request = new PatchHardwareRequest { HardwareId = Guid.NewGuid().ToString(), Name = "New Hardware Name" };
        var user = new User { Id = userId };
        var owner = new User();
        var home = new Home
        {
            Id = Guid.Parse(homeId),
            Members = [new UserHomePermission() { User = user, UserId = user.Id, Permissions = [] }],
            Owner = owner,
            OwnerId = owner.Id
        };
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner))
            .Returns(home);

        Assert.ThrowsException<HomePermissionException>(() => _homeService.UpdateHardware(homeId, request, user));
    }

    [TestMethod]
    public void UpdateHardware_InvalidHardwareId_ShouldThrowArgumentException()
    {
        var homeId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid();
        var request = new PatchHardwareRequest { HardwareId = "InvalidId", Name = "New Hardware Name" };
        var user = new User { Id = userId };
        var home = new Home
        {
            Id = Guid.Parse(homeId),
            Members = [],
            Owner = user,
            OwnerId = user.Id
        };
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner))
            .Returns(home);
        _userHomePermissionsRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<UserHomePermission, bool>>>()))
            .Returns(new UserHomePermission { Permissions = [HomePermission.ChangeDeviceName] });

        Assert.ThrowsException<InvalidValueException>(() => _homeService.UpdateHardware(homeId, request, user));
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void AddNotificationMember_MemberNotFound_ThrowsMemberNotFoundException()
    {
        var homeId = Guid.NewGuid().ToString();
        var memberEmail = "test@example.com";
        var home = new Home { Id = Guid.NewGuid(), NotificationMembers = [] };
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Returns((User)null);

        _homeService.AddNotificationMember(homeId, memberEmail);
    }

    [TestMethod]
    public void AddNotificationMember_Success_AddsNotificationMember()
    {
        var homeId = Guid.NewGuid().ToString();
        var memberEmail = "test@example.com";
        var home = new Home { Id = Guid.Parse(homeId), NotificationMembers = [] };
        var user = new User { Id = Guid.NewGuid(), Email = memberEmail };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _userRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<User, bool>>>())).Returns(user);
        _notificationMembersRepositoryMock.Setup(repo => repo.Add(It.IsAny<NotificationMember>())).Verifiable();

        _homeService.AddNotificationMember(homeId, memberEmail);

        _notificationMembersRepositoryMock.Verify(repo => repo.Add(It.IsAny<NotificationMember>()), Times.Once);
        Assert.IsTrue(home.NotificationMembers.Any(nm => nm.UserId == user.Id));
    }

    [TestMethod]
    public void ChangeHardwareRoom_ShouldChangeRoom_WhenUserHasPermissionAndRoomExists()
    {
        var homeId = Guid.NewGuid().ToString();
        var newRoom = "Living Room";
        var hardwareId = Guid.NewGuid().ToString();

        var user = new User { Id = Guid.NewGuid() };
        var home = new Home
        {
            Id = Guid.NewGuid(),
            Rooms = [newRoom, "Bedroom"],
            Devices = [new Hardware { Id = Guid.Parse(hardwareId), Room = "Bedroom" }],
            Owner = user,
            OwnerId = user.Id
        };

        var userHomePermission = new UserHomePermission
        {
            User = user,
            UserId = user.Id,
            HomeId = home.Id,
            Permissions = [HomePermission.ChangeHardwareRoom]
        };

        home.Members.Add(userHomePermission);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner)).Returns(home);

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                h => h.Id.ToString() == homeId, h => h.Devices)).Returns(home);

        _homeService.ChangeHardwareRoom(homeId, newRoom, hardwareId, user);

        Assert.AreEqual(newRoom, home.Devices.First(h => h.Id.ToString() == hardwareId).Room);
        _hardwareRepositoryMock.Verify(repo => repo.Update(It.IsAny<Hardware>()), Times.Once);
    }

    [TestMethod]
    public void ChangeHardwareRoom_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var homeId = Guid.NewGuid().ToString();
        var newRoom = "Living Room";
        var hardwareId = Guid.NewGuid().ToString();

        var user = new User { Id = Guid.NewGuid() };

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns((Home)null);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.ChangeHardwareRoom(homeId, newRoom, hardwareId, user));
    }

    [TestMethod]
    public void ChangeHardwareRoom_ShouldThrowException_WhenRoomDoesNotExistInHome()
    {
        var homeId = Guid.NewGuid().ToString();
        var newRoom = "Living Room";
        var hardwareId = Guid.NewGuid().ToString();

        var user = new User { Id = Guid.NewGuid() };
        var home = new Home
        {
            Id = Guid.NewGuid(),
            Rooms = ["Bedroom"],
            Devices = [new Hardware { Id = Guid.Parse(hardwareId), Room = "Kitchen" }],
            Owner = user,
            OwnerId = user.Id
        };

        var userHomePermission = new UserHomePermission
        {
            User = user,
            UserId = user.Id,
            HomeId = home.Id,
            Permissions = [HomePermission.ChangeHardwareRoom]
        };

        home.Members.Add(userHomePermission);

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                  h => h.Id.ToString() == homeId,
                  h => h.Members,
                  h => h.Owner)).Returns(home);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.ChangeHardwareRoom(homeId, newRoom, hardwareId, user));
    }

    [TestMethod]
    public void ChangeHardwareRoom_ShouldThrowException_WhenHardwareDoesNotExistInHome()
    {
        var homeId = Guid.NewGuid().ToString();
        var newRoom = "Living Room";
        var hardwareId = Guid.NewGuid().ToString();

        var user = new User { Id = Guid.NewGuid() };
        var home = new Home
        {
            Id = Guid.NewGuid(),
            Rooms = [newRoom],
            Devices = [],
            OwnerId = user.Id,
            Owner = user
        };

        var userHomePermission = new UserHomePermission
        {
            User = user,
            UserId = user.Id,
            HomeId = home.Id,
            Permissions = [HomePermission.ChangeHardwareRoom]
        };

        home.Members.Add(userHomePermission);

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                  h => h.Id.ToString() == homeId,
                  h => h.Members,
                  h => h.Owner)).Returns(home);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.ChangeHardwareRoom(homeId, newRoom, hardwareId, user));
    }

    [TestMethod]
    public void ChangeHardwareRoom_ShouldThrowException_WhenUserHasNoPermission()
    {
        var homeId = Guid.NewGuid().ToString();
        var newRoom = "Living Room";
        var hardwareId = Guid.NewGuid().ToString();

        var user = new User { Id = Guid.NewGuid() };
        var user2 = new User { Id = Guid.NewGuid() };
        var home = new Home
        {
            Id = Guid.NewGuid(),
            Rooms = [newRoom],
            Devices = [new Hardware { Id = Guid.Parse(hardwareId), Room = "Kitchen" }],
            Owner = user,
            OwnerId = user.Id
        };

        var userHomePermission = new UserHomePermission
        {
            User = user2,
            UserId = user2.Id,
            HomeId = home.Id,
            Permissions = []
        };

        home.Members.Add(userHomePermission);

        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>())).Returns(home);
        _homeRepositoryMock.Setup(repo => repo.GetOrDefault(
                  h => h.Id.ToString() == homeId,
                  h => h.Members,
                  h => h.Owner)).Returns(home);

        var exception = Assert.ThrowsException<HomePermissionException>(() => _homeService.ChangeHardwareRoom(homeId, newRoom, hardwareId, user2));
    }

    [TestMethod]
    public void GetHomeResponseById_ShouldReturnHomeResponse_WhenHomeExists()
    {
        var homeId = Guid.NewGuid();
        var home = new Home
        {
            Id = homeId,
            Name = "Test Home",
            Street = "Test Street",
            StreetNumber = "123",
            Ubication = new UbicationGeo(10, 20),
            MaxMembers = 5,
            Rooms = ["Living Room", "Kitchen"],
            Owner = new User { Email = "owner@test.com" }
        };

        _homeRepositoryMock
            .Setup(repo => repo.Get(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>()))
            .Returns(home);

        var result = _homeService.GetHomeResponseById(homeId);

        Assert.IsNotNull(result);
        Assert.AreEqual(homeId, result.Id);
        Assert.AreEqual("Test Home", result.Name);
        Assert.AreEqual("Test Street", result.Street);
        Assert.AreEqual("123", result.StreetNumber);
        Assert.AreEqual("owner@test.com", result.Owner);
    }

    [TestMethod]
    public void GetHomeResponseById_ShouldThrowException_WhenHomeDoesNotExist()
    {
        var homeId = Guid.NewGuid();

        Assert.ThrowsException<NullReferenceException>(() => _homeService.GetHomeResponseById(homeId));
    }

    [TestMethod]
    public void GetRooms_ShouldReturnRoomHardwareMap_WhenHomeExists()
    {
        var homeId = Guid.NewGuid().ToString();
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Name = "Test", Id = hardwareId, Room = "Living Room", Device = new Device { Id = Guid.NewGuid(), Photos = ["a", "b"], Name = "Device 3", Model = "Model 3", Type = DeviceType.SecurityCam, Description = "des", Company = new Company() { Name = "ab" } } };
        var home = new Home
        {
            Id = Guid.Parse(homeId),
            Rooms = ["Living Room", "Bedroom"],
            Devices = [hardware]
        };

        _homeRepositoryMock
            .Setup(repo => repo.GetOrDefault(
                        h => h.Id.ToString() == homeId, h => h.Devices))
            .Returns(home);
        _hardwareRepositoryMock.Setup(r => r.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company))
            .Returns(hardware);

        var result = _homeService.GetRooms(homeId);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
        Assert.IsTrue(result.ContainsKey("Living Room"));
        Assert.IsTrue(result.ContainsKey("Bedroom"));
    }

    [TestMethod]
    public void GetRooms_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var homeId = Guid.NewGuid().ToString();

        _homeRepositoryMock
            .Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>()))
            .Returns((Home)null);

        Assert.ThrowsException<NotFoundException>(() => _homeService.GetRooms(homeId));
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void AddRooms_ShouldThrowException_WhenHomeIsNull()
    {
        var homeId = Guid.NewGuid().ToString();

        _homeRepositoryMock
            .Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<Home, bool>>>(), It.IsAny<Expression<Func<Home, object>>[]>()))
            .Returns((Home)null);

        _homeService.GetRooms(homeId);
    }

    [TestMethod]
    public void HardwareTurnOn_ShouldCallDeviceService_WhenUserIsMember()
    {
        var user = new User { Id = Guid.NewGuid() };
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Online = false, Name = "Test", Id = hardwareId, Room = "Living Room", Device = new Device { Id = Guid.NewGuid(), Photos = ["a", "b"], Name = "Device 3", Model = "Model 3", Type = DeviceType.SecurityCam, Description = "des", Company = new Company() { Name = "ab" } } };

        var home = new Home
        {
            Id = Guid.NewGuid(),
            Owner = user,
            OwnerId = user.Id,
            Members = [new UserHomePermission { User = user, UserId = user.Id }],
            Devices = [hardware]
        };
        var homeId = home.Id.ToString();
        var request = new HardwareChangeStatusRequest { HomeId = homeId, HardwareId = hardwareId.ToString() };

        _homeRepositoryMock.Setup(repo => repo.Get(
                   h => h.Id.ToString() == homeId,
                   h => h.Members,
                   h => h.Owner))
            .Returns(home);

        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company))
            .Returns(hardware);

        _homeService.HardwareTurnOn(request, user);
        Assert.IsTrue(hardware.Online);
    }

    [TestMethod]
    public void HardwareTurnOff_ShouldCallDeviceService_WhenUserIsMember()
    {
        var user = new User { Id = Guid.NewGuid() };
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Name = "Test", Id = hardwareId, Room = "Living Room", Device = new Device { Id = Guid.NewGuid(), Photos = ["a", "b"], Name = "Device 3", Model = "Model 3", Type = DeviceType.SecurityCam, Description = "des", Company = new Company() { Name = "ab" } } };

        var home = new Home
        {
            Id = Guid.NewGuid(),
            Owner = user,
            OwnerId = user.Id,
            Members = [new UserHomePermission { User = user, UserId = user.Id }],
            Devices = [hardware]
        };
        var homeId = home.Id.ToString();
        var request = new HardwareChangeStatusRequest { HomeId = homeId, HardwareId = hardwareId.ToString() };

        _homeRepositoryMock.Setup(repo => repo.Get(
                   h => h.Id.ToString() == homeId,
                   h => h.Members,
                   h => h.Owner))
            .Returns(home);

        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company))
            .Returns(hardware);

        _homeService.HardwareTurnOff(request, user);
        Assert.IsFalse(hardware.Online);
    }

    [TestMethod]
    public void HardwareTurnOff_ShouldThrowExcept_WhenUserIsMember()
    {
        var user = new User { Id = Guid.NewGuid() };
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Online = false, Name = "Test", Id = hardwareId, Room = "Living Room", Device = new Device { Id = Guid.NewGuid(), Photos = ["a", "b"], Name = "Device 3", Model = "Model 3", Type = DeviceType.SecurityCam, Description = "des", Company = new Company() { Name = "ab" } } };

        var home = new Home
        {
            Id = Guid.NewGuid(),
            Owner = user,
            OwnerId = user.Id,
            Members = [new UserHomePermission { User = user, UserId = user.Id }],
            Devices = [hardware]
        };
        var homeId = home.Id.ToString();
        var request = new HardwareChangeStatusRequest { HomeId = homeId, HardwareId = hardwareId.ToString() };

        _homeRepositoryMock.Setup(repo => repo.Get(
                   h => h.Id.ToString() == homeId,
                   h => h.Members,
                   h => h.Owner))
            .Returns(home);

        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company))
            .Returns(hardware);

        var exception = Assert.ThrowsException<HardwareFeatureNotSupportedException>(() => _homeService.HardwareTurnOff(request, user));
    }

    [TestMethod]
    public void HardwareTurnOn_ShouldThrowExcept_WhenUserIsMember()
    {
        var user = new User { Id = Guid.NewGuid() };
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Name = "Test", Id = hardwareId, Room = "Living Room", Device = new Device { Id = Guid.NewGuid(), Photos = ["a", "b"], Name = "Device 3", Model = "Model 3", Type = DeviceType.SecurityCam, Description = "des", Company = new Company() { Name = "ab" } } };

        var home = new Home
        {
            Id = Guid.NewGuid(),
            Owner = user,
            OwnerId = user.Id,
            Members = [new UserHomePermission { User = user, UserId = user.Id }],
            Devices = [hardware]
        };
        var homeId = home.Id.ToString();
        var request = new HardwareChangeStatusRequest { HomeId = homeId, HardwareId = hardwareId.ToString() };

        _homeRepositoryMock.Setup(repo => repo.Get(
                   h => h.Id.ToString() == homeId,
                   h => h.Members,
                   h => h.Owner))
            .Returns(home);

        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company))
            .Returns(hardware);

        var exception = Assert.ThrowsException<HardwareFeatureNotSupportedException>(() => _homeService.HardwareTurnOn(request, user));
    }

    [TestMethod]
    public void HardwareTurnOn_WhenUserIsNotMember()
    {
        var user = new User { Id = Guid.NewGuid() };
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Name = "Test", Id = hardwareId, Room = "Living Room", Device = new Device { Id = Guid.NewGuid(), Photos = ["a", "b"], Name = "Device 3", Model = "Model 3", Type = DeviceType.SecurityCam, Description = "des", Company = new Company() { Name = "ab" } } };
        var user2 = new User { Id = Guid.NewGuid() };
        var home = new Home
        {
            Id = Guid.NewGuid(),
            Owner = user,
            OwnerId = user.Id,
            Members = [new UserHomePermission { User = user, UserId = user.Id }],
            Devices = [hardware]
        };
        var homeId = home.Id.ToString();
        var request = new HardwareChangeStatusRequest { HomeId = homeId, HardwareId = hardwareId.ToString() };

        _homeRepositoryMock.Setup(repo => repo.Get(
                   h => h.Id.ToString() == homeId,
                   h => h.Members,
                   h => h.Owner))
            .Returns(home);

        _hardwareRepositoryMock.Setup(repo => repo.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company))
            .Returns(hardware);

        var exception = Assert.ThrowsException<NotFoundException>(() => _homeService.HardwareTurnOn(request, user2));
    }
}
