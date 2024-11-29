using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class MembersControllerTests
{
    private Mock<IMemberService>? _mockMemberService;
    private MembersController? _controller;
    private Mock<HttpContext>? _mockHttpContext;

    [TestInitialize]
    public void Setup()
    {
        _mockMemberService = new Mock<IMemberService>();
        _controller = new MembersController(_mockMemberService.Object);
        _mockHttpContext = new Mock<HttpContext>();

        var items = new Dictionary<object, object>
        {
            { "UserLogged", new User { Email = "test@example.com", Password = "testpassword" } }
        };

        _mockHttpContext.Setup(c => c.Items).Returns(items);
        _controller.ControllerContext = new ControllerContext
        {
            HttpContext = _mockHttpContext.Object
        };
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void AddPermission_ShouldThrowValidationException_WhenModelStateIsInvalid()
    {
        var memberId = Guid.NewGuid();
        var permissionRequest = new PermissionRequest
        {
            HomeId = "home-123",
            Permissions = { }
        };

        _controller!.ModelState.AddModelError("Permissions", "The Permissions field is required.");

        _controller.AddPermission(memberId, permissionRequest);
    }

    [TestMethod]
    public void AddNotificationMembers_ReturnsOk_WhenEmailsAreValid()
    {
        var homeId = "home-123";
        var emails = new List<string> { "user1@example.com", "user2@example.com" };

        var result = _controller.AddNotificationMembers(homeId, emails) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("Notification members added successfully.", result.Value.GetType().GetProperty("Message")?.GetValue(result.Value));

        foreach (var email in emails)
        {
            _mockMemberService.Verify(ms => ms.AddNotificationMember(homeId, email), Times.Once);
        }
    }

    [TestMethod]
    public void GetMembers_ReturnsOk_WithMembers()
    {
        // Arrange
        var homeId = "home-123";
        var expectedMembers = new List<MemberResponse>
    {
        new MemberResponse(
            Guid.NewGuid(),
            "User One",
            "Surname One",
            "user1@example.com",
            ["Permission1", "Permission2"],
            false),
        new MemberResponse(
            Guid.NewGuid(),
            "User Two",
            "Surname Two",
            "user2@example.com",
            ["Permission3"],
            true)
    };

        _mockMemberService.Setup(ms => ms.GetMembers(homeId)).Returns(expectedMembers);

        var result = _controller.GetMembers(homeId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var memberList = result.Value as List<MemberResponse>;
        Assert.IsNotNull(memberList);
        Assert.AreEqual(expectedMembers.Count, memberList.Count);

        for (var i = 0; i < expectedMembers.Count; i++)
        {
            Assert.AreEqual(expectedMembers[i].Id, memberList[i].Id);
            Assert.AreEqual(expectedMembers[i].Email, memberList[i].Email);
            Assert.AreEqual(expectedMembers[i].Name, memberList[i].Name);
            Assert.AreEqual(expectedMembers[i].Surname, memberList[i].Surname);
            CollectionAssert.AreEqual(expectedMembers[i].Permissions, memberList[i].Permissions);
            Assert.AreEqual(expectedMembers[i].Notification, memberList[i].Notification);
        }
    }

    [TestMethod]
    public void GetMembers_ReturnsOk_WithNoMembers()
    {
        var homeId = "home-123";
        _mockMemberService.Setup(ms => ms.GetMembers(homeId)).Returns([]);

        var result = _controller.GetMembers(homeId) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(0, ((List<MemberResponse>)result.Value).Count);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void AddMember_ShouldThrowValidationException_WhenModelStateIsInvalid()
    {
        var homeId = "home-123";

        _controller!.ModelState.AddModelError("Email", "The Email field is required.");

        var result = _controller.AddMember(homeId, null!);

        Assert.IsInstanceOfType(result, typeof(BadRequestResult));
    }

    [TestMethod]
    public void AddMember_ShouldReturnOk_WhenModelStateIsValid()
    {
        var homeId = "home-123";
        var memberRequest = new MemberRequest { MemberEmail = "newmember@example.com" };
        var user = new User { Email = "test@example.com", Password = "testpassword" };
        _mockHttpContext.Setup(c => c.Items["UserLogged"]).Returns(user);

        var result = _controller.AddMember(homeId, memberRequest) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("Member added successfully.", result.Value.GetType().GetProperty("Message")?.GetValue(result.Value));
        _mockMemberService.Verify(ms => ms.AddMember(memberRequest, homeId, null), Times.Once);
    }

    [TestMethod]
    public void AddPermission_ShouldReturnOk_WhenModelStateIsValid()
    {
        var memberId = Guid.NewGuid();
        var permissionRequest = new PermissionRequest
        {
            HomeId = "home-123",
            Permissions = ["ListDevices"]
        };
        var user = new User { Email = "test@example.com", Password = "testpassword" };
        _mockHttpContext.Setup(c => c.Items["UserLogged"]).Returns(user);

        var result = _controller.AddPermission(memberId, permissionRequest) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("Permissions added successfully.", result.Value.GetType().GetProperty("Message")?.GetValue(result.Value));

        _mockMemberService.Verify(ms => ms.AddPermission(permissionRequest.HomeId, memberId, permissionRequest.Permissions, null), Times.Once);
    }
}
