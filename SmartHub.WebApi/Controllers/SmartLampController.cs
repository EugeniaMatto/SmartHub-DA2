using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/smart-lamps")]
public class SmartLampController : SmartHubBaseController
{
    private readonly ISmartLampService _smartLampService;

    public SmartLampController(ISmartLampService service)
    {
        _smartLampService = service;
    }

    [HttpPost]
    public IActionResult AddSmartLamp([FromBody] DeviceRequest device)
    {
        NotValidModel();
        var user = GetUserLogged();
        var id = _smartLampService.AddSmartLamp(device, user);
        return Ok(new { id });
    }

    [HttpPost("on")]
    public IActionResult On(Guid hardware_id)
    {
        var notifications = _smartLampService.On(hardware_id);
        return Ok(new { notifications });
    }

    [HttpPost("off")]
    public IActionResult Off(Guid hardware_id)
    {
        var notifications = _smartLampService.Off(hardware_id);
        return Ok(new { notifications });
    }
}
