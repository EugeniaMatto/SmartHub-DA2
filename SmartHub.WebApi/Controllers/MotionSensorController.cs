using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/motion-sensors")]
public class MotionSensorController : SmartHubBaseController
{
    private readonly IMotionSensorService _sensorService;

    public MotionSensorController(IMotionSensorService sensorService)
    {
        _sensorService = sensorService;
    }

    [HttpPost]
    public IActionResult AddMotionSensor([FromBody] DeviceRequest device)
    {
        NotValidModel();

        var user = GetUserLogged();
        var id = _sensorService.AddMotionSensor(device, user);
        return Ok(new { id });
    }

    [HttpPost("motion-detection")]
    public IActionResult MotionDetection(Guid hardware_id)
    {
        var notifications = _sensorService.MotionDetection(hardware_id);
        return Ok(new { notifications });
    }
}
