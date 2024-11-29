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
public class HomeControllerTest
{
    private readonly Mock<IHomeService> _mockHomeService;
    private readonly HomeController _homeController;
    private readonly Mock<HttpContext> _mockHttpContext;

    public HomeControllerTest()
    {
        _mockHomeService = new Mock<IHomeService>();
        _mockHttpContext = new Mock<HttpContext>();

        var user = new User { Id = Guid.NewGuid(), Name = "TestUser" };
        _mockHttpContext.Setup(x => x.Items[It.IsAny<object>()]).Returns(user);

        _homeController = new HomeController(_mockHomeService.Object)
        {
            ControllerContext = new ControllerContext
            {
                HttpContext = _mockHttpContext.Object
            }
        };
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void NewHome_ShouldReturnBadRequest_WhenModelStateIsInvalid()
    {
        _homeController.ModelState.AddModelError("Street", "The Street field is required.");
        var requestHome = new HomeRequest() { Name = "name" };

        _homeController.Add(requestHome);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void AddDevice_ShouldReturnBadRequest_WhenModelStateIsInvalid()
    {
        _homeController.ModelState.AddModelError("DeviceId", "The DeviceId field is required.");
        var request = new RequestHardware() { Name = "name" };

        _homeController.AddDevice("homeId", request);
    }

    [TestMethod]
    public void UpdateNameDevice_ShouldReturnOk_WhenNameIsUpdatedSuccessfully()
    {
        var request = new PatchHardwareRequest() { Name = "name", HardwareId = "id" };
        _mockHomeService.Setup(x => x.UpdateHardware(It.IsAny<string>(), It.IsAny<PatchHardwareRequest>(), It.IsAny<User>()))
            .Returns(Guid.NewGuid());

        var result = _homeController.UpdateNameDevice("homeId", request) as OkObjectResult;

        Assert.AreEqual("name", request.Name);
        Assert.AreEqual("id", request.HardwareId);
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("{ msg = Hardware name changed successfully }", result.Value.ToString());
        _mockHomeService.Verify(x => x.UpdateHardware(It.IsAny<string>(), It.IsAny<PatchHardwareRequest>(), It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    public void GetDevices_ShouldReturnOk_WithDevices()
    {
        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Light Bulb",
            Model = "LB-100",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["b", "a"],
            Company = new Company()
            { Name = "AB" }
        };

        var devices = new List<Hardware> { new Hardware { Name = "Device 1", Device = device }, new Hardware { Name = "Device 2", Device = device } };
        _mockHomeService.Setup(x => x.GetDevices(It.IsAny<string>(), It.IsAny<User>()))
            .Returns(devices.ConvertAll(h => new HardwareResponse(h)));

        var result = _homeController.GetDevices("homeId") as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        _mockHomeService.Verify(x => x.GetDevices(It.IsAny<string>(), It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void UpdateNameDevice_ShouldReturnBadRequest_WhenModelStateIsInvalid()
    {
        _homeController.ModelState.AddModelError("Name", "The Name field is required.");
        var request = new PatchHardwareRequest() { Name = "New Device Name" };

        _homeController.UpdateNameDevice("homeId", request);
    }

    [TestMethod]
    public void AddDevice_ShouldReturnOk_WhenModelStateIsValid()
    {
        var request = new RequestHardware() { Name = "Device Name" };
        var user = new User { Id = Guid.NewGuid(), Name = "TestUser" };
        _mockHttpContext.Setup(x => x.Items[It.IsAny<object>()]).Returns(user);
        _mockHomeService.Setup(x => x.AddHardware(It.IsAny<string>(), It.IsAny<RequestHardware>(), It.IsAny<User>()))
            .Returns(Guid.NewGuid());

        var result = _homeController.AddDevice("homeId", request) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        _mockHomeService.Verify(x => x.AddHardware(It.IsAny<string>(), It.IsAny<RequestHardware>(), It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    public void NewHome_ShouldReturnOk_WhenModelStateIsValid()
    {
        var requestHome = new HomeRequest() { Name = "New Home" };
        var user = new User { Id = Guid.NewGuid(), Name = "TestUser" };
        _mockHttpContext.Setup(x => x.Items[It.IsAny<object>()]).Returns(user);
        _mockHomeService.Setup(x => x.AddHome(It.IsAny<HomeRequest>(), It.IsAny<User>()))
            .Returns(new Home().Id.ToString());

        var result = _homeController.Add(requestHome) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        _mockHomeService.Verify(x => x.AddHome(It.IsAny<HomeRequest>(), It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    public void GetRooms_ShouldReturnOk_WithRoomsAndDevices()
    {
        var hardware = new Hardware
        {
            Id = Guid.NewGuid(),
            Name = "Smart Light Bulb",
            Online = true,
            Home = new Home
            {
                Id = Guid.NewGuid(),
                Name = "Smart Home",
                MaxMembers = 5,
                Rooms = ["Living Room", "Kitchen", "Bedroom"],
                OwnerId = Guid.NewGuid()
            },
            HomeId = Guid.NewGuid(),
            Device = new Device
            {
                Id = Guid.NewGuid(),
                Name = "Light Bulb",
                Model = "LB-100",
                Type = DeviceType.MotionSensor,
                Description = "A smart light bulb that can be controlled remotely.",
                Photos = ["a", "b"],
                Company = new Company() { Name = "c" }
            },
            DeviceId = Guid.NewGuid(),
            Room = "Living Room"
        };
        var rooms = new Dictionary<string, List<HardwareResponse>>
    {
        { "Living Room", new List<HardwareResponse> { new HardwareResponse(hardware), new HardwareResponse(hardware) } },
        { "Bedroom", new List<HardwareResponse> { new HardwareResponse(hardware) } }
    };
        _mockHomeService.Setup(x => x.GetRooms(It.IsAny<string>())).Returns(rooms);

        var result = _homeController.GetRooms("homeId") as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(rooms, result.Value);
        _mockHomeService.Verify(x => x.GetRooms(It.IsAny<string>()), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void GetRooms_ShouldThrowHomeNotFoundException_WhenHomeDoesNotExist()
    {
        _mockHomeService.Setup(x => x.GetRooms(It.IsAny<string>())).Throws(new NotFoundException("home", "id found"));

        _homeController.GetRooms("invalidHomeId");
    }

    [TestMethod]
    public void GetRooms_ShouldReturnOk_WithEmptyRooms_WhenNoDevicesExist()
    {
        var emptyRooms = new Dictionary<string, List<HardwareResponse>>();
        _mockHomeService.Setup(x => x.GetRooms(It.IsAny<string>())).Returns(emptyRooms);

        var result = _homeController.GetRooms("homeId") as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(emptyRooms, result.Value);
        _mockHomeService.Verify(x => x.GetRooms(It.IsAny<string>()), Times.Once);
    }

    [TestMethod]
    public void AddRooms_ShouldReturnOk_WhenRoomsAreAddedSuccessfully()
    {
        var homeId = "testHomeId";
        var request = new PatchRoomRequest { Rooms = ["Living Room", "Bedroom"] };
        _mockHomeService.Setup(x => x.AddRooms(homeId, request.Rooms, It.IsAny<User>())).Verifiable();

        var result = _homeController.AddRooms(homeId, request) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("{ msg = Rooms added successfully }", result.Value.ToString());
        _mockHomeService.Verify(x => x.AddRooms(homeId, request.Rooms, It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void AddRooms_ShouldThrowValidationException_WhenModelStateIsInvalid()
    {
        var homeId = "testHomeId";
        var request = new PatchRoomRequest { Rooms = ["Living Room"] };

        _homeController.ModelState.AddModelError("Rooms", "The Rooms field is required.");

        _homeController.AddRooms(homeId, request);
    }

    [TestMethod]
    public void UpdateRoomDevice_ShouldReturnOk_WhenRoomIsUpdatedSuccessfully()
    {
        var homeId = "homeId";
        var request = new PatchRoomHardwareRequest
        {
            Room = "Living Room",
            HardwareId = "deviceId"
        };

        _mockHomeService.Setup(x => x.ChangeHardwareRoom(homeId, request.Room, request.HardwareId, It.IsAny<User>()))
            .Verifiable();

        var result = _homeController.UpdateRoomDevice(homeId, request) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("{ msg = Hardware room changed successfully }", result.Value.ToString());

        _mockHomeService.Verify(x => x.ChangeHardwareRoom(homeId, request.Room, request.HardwareId, It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(ValidationException))]
    public void UpdateRoomDevice_ShouldReturnBadRequest_WhenModelStateIsInvalid()
    {
        var homeId = "testHomeId";
        var request = new PatchRoomHardwareRequest { Room = "Living Room" };

        _homeController.ModelState.AddModelError("Rooms", "The Rooms field is required.");

        _homeController.UpdateRoomDevice(homeId, request);
    }

    [TestMethod]
    public void GetPermissions_ShouldReturnOk()
    {
        var permissionStrings = Enum.GetValues(typeof(HomePermission))
            .Cast<HomePermission>()
            .Select(permission => permission.ToString())
            .ToList();

        var result = _homeController.GetPermissions() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(permissionStrings.ToString(), result.Value.ToString());
    }

    [TestMethod]
    public void HardwareOn_ShouldReturnOk_WhenRequestIsValid()
    {
        var request = new HardwareChangeStatusRequest();
        var user = new User { Id = Guid.NewGuid(), Name = "TestUser" };

        _mockHttpContext.Setup(x => x.Items[It.IsAny<object>()]).Returns(user);

        var result = _homeController.HardwareOn(request) as OkObjectResult;

        _mockHomeService.Verify(s => s.HardwareTurnOn(request, user), Times.Once);
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
    }

    [TestMethod]
    public void HardwareOff_ShouldReturnOk_WhenRequestIsValid()
    {
        var request = new HardwareChangeStatusRequest();
        var user = new User { Id = Guid.NewGuid(), Name = "TestUser" };

        _mockHttpContext.Setup(x => x.Items[It.IsAny<object>()]).Returns(user);

        var result = _homeController.HardwareOff(request) as OkObjectResult;

        _mockHomeService.Verify(s => s.HardwareTurnOff(request, user), Times.Once);
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
    }
}
