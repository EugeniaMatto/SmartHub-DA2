using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public class MemberServiceTests
{
    private MemberService? _memberService;
    private Mock<IHomeService>? _mockHomeService;

    [TestInitialize]
    public void Setup()
    {
        _mockHomeService = new Mock<IHomeService>();
        _memberService = new MemberService(_mockHomeService.Object);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException), "No home found with the Id: {homeId}")]
    public void AddMember_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        var memberRequest = new MemberRequest
        {
            MemberEmail = "member@example.com",
            Permissions = { "AssociateDevices" }
        };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns((Home?)null);

        _memberService.AddMember(memberRequest, "homeId", new User());
    }

    [TestMethod]
    [ExpectedException(typeof(HomePermissionException))]
    public void AddMember_ShouldThrowException_WhenUserIsNotOwner()
    {
        var home = new Home { OwnerId = Guid.NewGuid() };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns(home);

        var user = new User { Id = Guid.NewGuid() };

        var memberRequest = new MemberRequest
        {
            MemberEmail = "member@example.com",
            Permissions = { "AssociateDevices" }
        };

        _memberService.AddMember(memberRequest, "homeId", user);
    }

    [TestMethod]
    public void AddMember_ShouldAddMember_WhenUserIsOwner()
    {
        var home = new Home { OwnerId = Guid.NewGuid() };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns(home);

        var user = new User { Id = home.OwnerId };

        var memberRequest = new MemberRequest
        {
            MemberEmail = "member@example.com",
            Permissions = { "AssociateDevices" }
        };

        _memberService.AddMember(memberRequest, "homeId", user);
        var listHomePermissions = new List<HomePermission> { HomePermission.AssociateDevices };

        _mockHomeService.Verify(repo => repo.AddMember(memberRequest.MemberEmail, "homeId", listHomePermissions), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void AddPermission_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns((Home?)null);

        _memberService.AddPermission("homeId", Guid.NewGuid(), ["AssociateDevices"], new User());
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), "Only the owner of the home can perform this action")]
    public void AddPermission_ShouldThrowException_WhenUserIsNotOwner()
    {
        var home = new Home { OwnerId = Guid.NewGuid() };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns(home);

        var user = new User { Id = Guid.NewGuid() };

        _memberService.AddPermission("homeId", Guid.NewGuid(), ["ListDevices"], user);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void AddPermission_ShouldThrowException_WhenNoPermissionsForUser()
    {
        var home = new Home { OwnerId = Guid.NewGuid() };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns(home);

        var user = new User { Id = home.OwnerId };

        _mockHomeService.Setup(repo => repo.GetUserHomePermission(It.IsAny<string>(), It.IsAny<Guid>())).Returns((UserHomePermission?)null);

        _memberService.AddPermission("homeId", Guid.NewGuid(), ["ListDevices"], user);
    }

    [TestMethod]
    public void AddPermission_ShouldAddPermission_WhenUserIsOwnerAndHasPermissions()
    {
        var home = new Home { OwnerId = Guid.NewGuid() };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns(home);

        var user = new User { Id = home.OwnerId };

        var userHomePermission = new UserHomePermission
        {
            Permissions = { HomePermission.ListDevices }
        };

        _mockHomeService.Setup(repo => repo.GetUserHomePermission(It.IsAny<string>(), It.IsAny<Guid>()))
            .Returns(userHomePermission);

        _memberService.AddPermission("homeId", Guid.NewGuid(), ["AssociateDevices"], user);

        Assert.IsTrue(userHomePermission.Permissions.Contains(HomePermission.AssociateDevices));
        Assert.IsTrue(userHomePermission.Permissions.Contains(HomePermission.ListDevices));
        _mockHomeService.Verify(repo => repo.AddHomePermission(userHomePermission), Times.Once);
    }

    [TestMethod]
    public void GetMembers_ShouldReturnListOfMembers()
    {
        var expectedMembers = new List<MemberResponse>
        {
            new MemberResponse(Guid.NewGuid(), "Member1", "Surname1", "member1@example.com", [], false),
            new MemberResponse(Guid.NewGuid(), "Member2", "Surname2", "member2@example.com", [], true)
        };

        _mockHomeService.Setup(service => service.GetMembers(It.IsAny<string>())).Returns(expectedMembers);

        var result = _memberService.GetMembers("homeId");

        Assert.AreEqual(expectedMembers.Count, result.Count);

        for (var i = 0; i < expectedMembers.Count; i++)
        {
            Assert.AreEqual(expectedMembers[i].Id, result[i].Id);
            Assert.AreEqual(expectedMembers[i].Name, result[i].Name);
            Assert.AreEqual(expectedMembers[i].Surname, result[i].Surname);
            Assert.AreEqual(expectedMembers[i].Email, result[i].Email);
            Assert.AreEqual(expectedMembers[i].Notification, result[i].Notification);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void AddNotificationMember_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns((Home?)null);

        _memberService.AddNotificationMember("homeId", "member@example.com");
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void AddNotificationMember_ShouldThrowMemberNotFoundException_WhenMemberDoesNotExist()
    {
        var home = new Home { Owner = new User { Email = "owner@example.com" } };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns(home);

        _mockHomeService.Setup(repo => repo.GetMemberByEmail(It.IsAny<string>(), It.IsAny<string>())).Returns((UserHomePermission?)null);

        _memberService.AddNotificationMember("homeId", "nonexistent@example.com");
    }

    [TestMethod]
    public void AddNotificationMember_ShouldAddNotificationMember_WhenMemberExists()
    {
        var home = new Home { Owner = new User { Email = "owner@example.com" } };

        _mockHomeService.Setup(repo => repo.GetHomeById(It.IsAny<string>())).Returns(home);

        var userHomePermission = new UserHomePermission();

        _mockHomeService.Setup(repo => repo.GetMemberByEmail(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(userHomePermission);

        _memberService.AddNotificationMember("homeId", "member@example.com");

        _mockHomeService.Verify(repo => repo.AddNotificationMember("homeId", "member@example.com"), Times.Once);
    }
}
