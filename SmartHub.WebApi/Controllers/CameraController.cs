using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/cameras")]
public class CameraController : SmartHubBaseController
{
    private readonly ICameraService _cameraService;

    public CameraController(ICameraService cameraService)
    {
        _cameraService = cameraService;
    }

    [HttpPost]
    public IActionResult AddCamera([FromBody] DeviceCamRequest device)
    {
        NotValidModel();
        var user = GetUserLogged();
        var id = _cameraService.AddCamera(device, user);
        return Ok(new { id });
    }

    [HttpPost("person-detection")]
    public IActionResult PersonDetection(Guid hardware_id, string? user_detection = null)
    {
        var notifications = _cameraService.PersonDetection(hardware_id, user_detection);
        return Ok(new { notifications });
    }

    [HttpPost("motion-detection")]
    public IActionResult MotionDetection(Guid hardware_id)
    {
        var notifications = _cameraService.MotionDetection(hardware_id);
        return Ok(new { notifications });
    }
}
