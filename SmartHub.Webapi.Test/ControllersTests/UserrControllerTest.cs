using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;
using SmartHub.WebApi;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class UserControllerTests
{
    private Mock<IUserService>? _mockUserService;
    private Mock<ISessionsService>? _mockSessionsService;
    private UserController? _userController;
    private Mock<HttpContext>? _mockHttpContext;
    private User? _user;

    [TestInitialize]
    public void Setup()
    {
        _mockUserService = new Mock<IUserService>();
        _mockSessionsService = new Mock<ISessionsService>();
        _userController = new UserController(_mockUserService.Object, _mockSessionsService.Object);
        _mockHttpContext = new Mock<HttpContext>();
        _mockHttpContext = new Mock<HttpContext>();
        _user = new User { Id = Guid.NewGuid(), Email = "test@example.com", Password = "testpassword", Name = "User", Surname = "Surname" };

        var items = new Dictionary<object, object>
        {
            { "UserLogged", new User { Email = "test@example.com", Password = "testpassword" } }
        };

        _mockHttpContext.Setup(c => c.Items).Returns(items);
        _userController.ControllerContext = new ControllerContext
        {
            HttpContext = _mockHttpContext.Object
        };
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Request not found.")]
    public void Login_ShouldThrowException_WhenLoginRequestIsNull()
    {
        _userController.Login(null);
    }

    [TestMethod]
    public void Login_ShouldReturnOk_WhenCredentialsAreValid()
    {
        var loginRequest = new LoginRequest
        {
            Email = "test@example.com",
            Password = "correctpassword"
        };

        var user = new User
        {
            Email = loginRequest.Email,
            Password = loginRequest.Password
        };

        var sessionToken = Guid.NewGuid();
        var expectedSessionResponse = new SessionResponse(
            user.Id,
            sessionToken,
            [],
            user.Name,
            string.Empty,
            string.Empty,
            string.Empty,
            DateTime.UtcNow);

        _mockUserService.Setup(service => service.Login(loginRequest.Email, loginRequest.Password))
            .Returns(user);

        _mockSessionsService.Setup(service => service.AddSession(user))
            .Returns(expectedSessionResponse);

        var result = _userController.Login(loginRequest) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        var tokenValue = result.Value;
        Assert.AreEqual(expectedSessionResponse, tokenValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void Login_ShouldThrowValidationException_WhenCredentialsAreInvalid()
    {
        var loginRequest = new LoginRequest
        {
            Email = "test@example.com",
            Password = "wrongpassword"
        };

        _mockUserService.Setup(service => service.Login(loginRequest.Email, loginRequest.Password))
            .Throws(new ValidationException("Invalid credentials"));

        _userController.Login(loginRequest);
    }

    [TestMethod]
    public void GetHomes_ShouldReturnOk_WithListOfHomes()
    {
        var homeResponse1 = new HomeResponse(
            Guid.NewGuid(),
            "Home 1",
            "Street 1",
            "123",
            new UbicationGeo(0, 0),
            "owner@example.com",
            [],
            5);

        var homeResponse2 = new HomeResponse(
            Guid.NewGuid(),
            "Home 2",
            "Street 2",
            "456",
            new UbicationGeo(0, 0),
            "member@example.com",
            [],
            3);
        var expectedHomes = new List<UserHomeResponse>
    {
        new UserHomeResponse(
        homeResponse1,
        "Owner",
        ["ChangeDeviceName", "ListDevices"]),
        new UserHomeResponse(
        homeResponse2,
        "Member",
        ["ListDevices"])
    };

        _mockUserService.Setup(service => service.GetHomes(It.IsAny<User>()))
            .Returns(expectedHomes);

        var user = new User { Email = "test@example.com", Password = "testpassword" };
        _mockHttpContext.Setup(c => c.Items["UserLogged"]).Returns(user);

        var result = _userController.GetHomes() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var homeList = result.Value as List<UserHomeResponse>;
        Assert.IsNotNull(homeList);
        Assert.AreEqual(expectedHomes.Count, homeList.Count);

        Assert.AreEqual(expectedHomes[0].Home.Id, homeList[0].Home.Id);
        Assert.AreEqual(expectedHomes[0].Home.Name, homeList[0].Home.Name);
        Assert.AreEqual(expectedHomes[0].Home.Street, homeList[0].Home.Street);
        Assert.AreEqual(expectedHomes[0].Home.StreetNumber, homeList[0].Home.StreetNumber);
        Assert.AreEqual(expectedHomes[0].Home.Ubication.Lat, homeList[0].Home.Ubication.Lat);
        Assert.AreEqual(expectedHomes[0].Home.Ubication.Lon, homeList[0].Home.Ubication.Lon);
        Assert.AreEqual(expectedHomes[0].Home.Owner, homeList[0].Home.Owner);
        Assert.AreEqual(expectedHomes[0].Home.MaxMembers, homeList[0].Home.MaxMembers);

        Assert.AreEqual(expectedHomes[1].Home.Id, homeList[1].Home.Id);
        Assert.AreEqual(expectedHomes[1].Home.Name, homeList[1].Home.Name);
        Assert.AreEqual(expectedHomes[1].Home.Street, homeList[1].Home.Street);
        Assert.AreEqual(expectedHomes[1].Home.StreetNumber, homeList[1].Home.StreetNumber);
        Assert.AreEqual(expectedHomes[1].Home.Owner, homeList[1].Home.Owner);
        Assert.AreEqual(expectedHomes[1].Home.MaxMembers, homeList[1].Home.MaxMembers);
    }

    [TestMethod]
    public void ChangeProfilePhoto_ShouldReturnOk_WhenPhotoIsUpdatedSuccessfully()
    {
        var request = new ProfilePhotoUpdateRequest { Photo = "newPhotoData" };

        _user = new User
        {
            Id = Guid.NewGuid(),
            Name = "User",
            Surname = "Surname",
            Email = "test@example.com",
            ProfilePhoto = "oldPhotoData",
            CreatedAt = DateTime.Now
        };

        var userResponse = new UserResponse(
                                    _user.Id,
                                    _user.Name,
                                    _user.Surname,
                                    _user.Email,
                                    request.Photo,
                                    _user.CreatedAt,
                                    _user.Roles.ConvertAll(r => r.ToString()));
        _mockUserService.Setup(service => service.ChangeProfilePhoto(_user, request.Photo))
            .Returns(userResponse);

        _mockHttpContext.Setup(c => c.Items[Item.UserLogged]).Returns(_user);
        var result = _userController.ChangeProfilePhoto(request) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(userResponse, result.Value);
    }
}
