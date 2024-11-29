using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/window-sensors")]
public class WindowSensorController : SmartHubBaseController
{
    private readonly IWindowSensorService _sensorService;

    public WindowSensorController(IWindowSensorService sensorService)
    {
        _sensorService = sensorService;
    }

    [HttpPost]
    public IActionResult AddSensor([FromBody] DeviceRequest device)
    {
        NotValidModel();
        var user = GetUserLogged();
        var id = _sensorService.AddSensor(device, user);
        return Ok(new { id });
    }

    [HttpPost("open")]
    public IActionResult Open(Guid hardware_id)
    {
        var notifications = _sensorService.Open(hardware_id);
        return Ok(new { notifications });
    }

    [HttpPost("close")]
    public IActionResult Close(Guid hardware_id)
    {
        var notifications = _sensorService.Close(hardware_id);
        return Ok(new { notifications });
    }
}
