using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/homes")]
public sealed class HomeController : SmartHubBaseController
{
    private readonly IHomeService homeService;

    public HomeController(IHomeService homeService)
    {
        this.homeService = homeService;
    }

    [HttpPost]
    public IActionResult Add([FromBody] HomeRequest requestHome)
    {
        NotValidModel();

        User user = GetUserLogged();
        var home_id = homeService.AddHome(requestHome, user);
        return Ok(new { home_id });
    }

    [HttpPost("{homeId}/devices")]
    public IActionResult AddDevice(string homeId, [FromBody] RequestHardware request)
    {
        NotValidModel();

        User user = GetUserLogged();
        var id = homeService.AddHardware(homeId, request, user);
        return Ok(new { id });
    }

    [HttpPatch("{homeId}/devices")]
    public IActionResult UpdateNameDevice(string homeId, [FromBody] PatchHardwareRequest request)
    {
        NotValidModel();

        User user = GetUserLogged();
        homeService.UpdateHardware(homeId, request, user);
        return Ok(new { msg = "Hardware name changed successfully" });
    }

    [HttpGet("{homeId}/devices")]
    public IActionResult GetDevices([FromRoute] string homeId)
    {
        User user = GetUserLogged();
        var devices = homeService.GetDevices(homeId, user);
        return Ok(devices);
    }

    [HttpGet("permissions")]
    public IActionResult GetPermissions()
    {
        var permissionStrings = Enum.GetValues(typeof(HomePermission))
            .Cast<HomePermission>()
            .Select(permission => permission.ToString())
            .ToList();

        return Ok(permissionStrings);
    }

    [HttpGet("{homeId}/rooms")]
    public IActionResult GetRooms([FromRoute] string homeId)
    {
        var devices = homeService.GetRooms(homeId);
        return Ok(devices);
    }

    [HttpPatch("{homeId}/rooms")]
    public IActionResult AddRooms([FromRoute] string homeId, [FromBody] PatchRoomRequest request)
    {
        NotValidModel();
        User user = GetUserLogged();
        homeService.AddRooms(homeId, request.Rooms, user);
        return Ok(new { msg = "Rooms added successfully" });
    }

    [HttpPatch("{homeId}/devices/room")]
    public IActionResult UpdateRoomDevice(string homeId, [FromBody] PatchRoomHardwareRequest request)
    {
        NotValidModel();

        User user = GetUserLogged();
        homeService.ChangeHardwareRoom(homeId, request.Room, request.HardwareId, user);
        return Ok(new { msg = "Hardware room changed successfully" });
    }

    [HttpPatch("devices/on")]
    public IActionResult HardwareOn([FromBody] HardwareChangeStatusRequest request)
    {
        NotValidModel();

        User user = GetUserLogged();
        homeService.HardwareTurnOn(request, user);
        return Ok(new { msg = "Hardware turn on successfully" });
    }

    [HttpPatch("devices/off")]
    public IActionResult HardwareOff([FromBody] HardwareChangeStatusRequest request)
    {
        NotValidModel();

        User user = GetUserLogged();
        homeService.HardwareTurnOff(request, user);
        return Ok(new { msg = "Hardware turn off successfully" });
    }
}
