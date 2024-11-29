using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/device-types")]
public class DeviceTypeController : SmartHubBaseController
{
    private readonly IDeviceService _deviceService;

    public DeviceTypeController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }

    [HttpGet]
    public IActionResult GetDeviceTypes()
    {
        var devices = _deviceService.GetDeviceTypes();
        return Ok(devices);
    }
}
