using SmartHub.Domain;
using SmartHub.Exceptions;

namespace SmartHub.Webapi.Test.Domain;
[TestClass]
public class HomeDomainTests
{
    private Home? _home;
    private UbicationGeo? _ubication;
    private User? _owner;

    [TestInitialize]
    public void SetUp()
    {
        _ubication = new UbicationGeo(-34, -56);
        _owner = new User
        {
            Name = "Juan",
            Surname = "Pérez",
            Email = "juanperez@example.com",
            Password = "pass123"
        };

        _home = new Home("name", "Avenida 18 de Julio", "1000", _ubication, _owner, 5);
    }

    [TestMethod]
    public void Test_SetName_ShouldUpdateName()
    {
        _home.Name = "Avenida Italia Casa";
        Assert.AreEqual("Avenida Italia Casa", _home.Name);
    }

    [TestMethod]
    public void Test_SetStreet_ShouldUpdateStreet()
    {
        _home.Street = "Avenida Italia";
        Assert.AreEqual("Avenida Italia", _home.Street);
    }

    [TestMethod]
    public void Test_SetStreetNumber_ShouldUpdateStreetNumber()
    {
        _home.StreetNumber = "2000";
        Assert.AreEqual("2000", _home.StreetNumber);
    }

    [TestMethod]
    public void Test_SetUbication_ShouldUpdateUbication()
    {
        var newUbication = new UbicationGeo(-30, -55);
        _home.Ubication = newUbication;
        Assert.AreEqual(-30, _home.Ubication.Lat);
        Assert.AreEqual(-55, _home.Ubication.Lon);
    }

    [TestMethod]
    public void Test_SetOwner_ShouldUpdateOwner()
    {
        var newOwner = new User
        {
            Name = "María",
            Surname = "Gómez",
            Email = "mariagomez@example.com",
            Password = "newpass123"
        };

        _home.Owner = newOwner;
        Assert.AreEqual("María", _home.Owner.Name);
        Assert.AreEqual("Gómez", _home.Owner.Surname);
    }

    [TestMethod]
    public void Test_SetMaxMembers_ShouldUpdateMaxMembers()
    {
        _home.MaxMembers = 10;
        Assert.AreEqual(10, _home.MaxMembers);
    }

    [TestMethod]
    public void Test_MembersList_ShouldBeEmptyInitially()
    {
        Assert.IsNotNull(_home.Members);
        Assert.AreEqual(0, _home.Members.Count);
    }

    [TestMethod]
    public void Test_AddUserToMembers_ShouldAddUserToList()
    {
        var member = new User
        {
            Name = "Juana",
            Surname = "Pou",
            Email = "juanap@example.com",
            Password = "newpass123"
        };
        var user = new UserHomePermission() { User = member };
        _home.Members.Add(user);
        Assert.AreEqual(1, _home.Members.Count);
        Assert.AreEqual(member, _home.Members[0].User);
    }

    [TestMethod]
    public void Test_NotificationMembersList_ShouldBeEmptyInitially()
    {
        Assert.IsNotNull(_home.NotificationMembers);
        Assert.AreEqual(0, _home.NotificationMembers.Count);
    }

    [TestMethod]
    public void Test_AddUserToNotificationMembers_ShouldAddUserToList()
    {
        var user = new User
        {
            Name = "Pedro",
            Surname = "Rodríguez",
            Email = "pedrorodriguez@example.com",
            Password = "pass456"
        };

        _home.NotificationMembers.Add(new NotificationMember() { User = user });
        Assert.AreEqual(1, _home.NotificationMembers.Count);
        Assert.AreEqual("Pedro", _home.NotificationMembers[0].User.Name);
    }

    [TestMethod]
    public void Test_DevicesList_ShouldBeEmptyInitially()
    {
        Assert.IsNotNull(_home.Devices);
        Assert.AreEqual(0, _home.Devices.Count);
    }

    [TestMethod]
    public void Test_AddDeviceToDevices_ShouldAddDeviceToList()
    {
        Guid id = new();
        var device = new Hardware
        {
            Id = id,
            Home = _home
        };

        _home.Devices.Add(device);
        Assert.AreEqual(1, _home.Devices.Count);
        Assert.AreEqual(id, _home.Devices[0].Id);
    }

    [TestMethod]
    public void AddMember_ShouldAddMember_WhenUnderMaxMembers()
    {
        var member = new UserHomePermission { User = _owner };
        _home.AddMember(member);

        Assert.AreEqual(1, _home.Members.Count);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidValueException))]
    public void AddMember_ShouldThrowException_WhenMaxMembersReached()
    {
        var member1 = new UserHomePermission { User = _owner };
        var member2 = new UserHomePermission
        {
            User = new User
            {
                Name = "Jane",
                Surname = "Doe",
                Email = "jane.doe@example.com",
                Password = "pass123"
            }
        };

        _home.AddMember(member1);
        _home.AddMember(member2);
        _home.MaxMembers = 2;

        var member3 = new UserHomePermission
        {
            User = new User
            {
                Name = "Extra User",
                Surname = "Extra",
                Email = "extramember@example.com",
                Password = "pass123"
            }
        };
        _home.AddMember(member3);
    }

    [TestMethod]
    public void RemoveMember_ShouldRemoveMember_WhenMemberExists()
    {
        var member = new UserHomePermission { User = _owner };
        _home.AddMember(member);
        _home.RemoveMember(member);

        Assert.AreEqual(0, _home.Members.Count);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void RemoveMember_ShouldThrowException_WhenMemberDoesNotExist()
    {
        var member = new UserHomePermission { User = _owner };
        _home.RemoveMember(member);
    }

    [TestMethod]
    public void GetAndSet_Id_ShouldWorkCorrectly()
    {
        var userHomePermission = new UserHomePermission();
        var expectedId = Guid.NewGuid();

        userHomePermission.Id = expectedId;

        Assert.AreEqual(expectedId, userHomePermission.Id);
    }

    [TestMethod]
    public void GetAndSet_HomeId_ShouldWorkCorrectly()
    {
        var userHomePermission = new UserHomePermission();
        var expectedHomeId = Guid.NewGuid();

        userHomePermission.HomeId = expectedHomeId;

        Assert.AreEqual(expectedHomeId, userHomePermission.HomeId);
    }
}
