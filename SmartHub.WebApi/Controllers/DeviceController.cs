using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/devices")]
public class DevicesController : SmartHubBaseController
{
    private readonly IDeviceService _deviceService;

    public DevicesController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }

    [HttpGet]
    public ActionResult GetDevices([FromQuery] DeviceFilterRequest filter)
    {
        var devices = _deviceService.GetDevices(filter);
        return Ok(devices);
    }

    [HttpPost("import")]
    public IActionResult ImportDevices([FromBody] ImportDevicesRequest request)
    {
        NotValidModel();
        var devices = _deviceService.ImportDevices(request, GetUserLogged());
        return Ok(devices);
    }

    [HttpGet("import")]
    public IActionResult GetImporters()
    {
        var importers = _deviceService.GetRegisteredImporters();
        return Ok(importers);
    }

    [HttpPost("validator")]
    public IActionResult SelectDeviceModelValidator([FromBody] DeviceModelValidatorRequest request)
    {
        NotValidModel();
        var response = _deviceService.SelectDeviceValidator(request.Validator, GetUserLogged());
        return Ok(new { msg = response });
    }

    [HttpGet("validator")]
    public IActionResult GetDeviceModelValidators()
    {
        var validators = _deviceService.GetRegisteredValidators();
        return Ok(validators);
    }
}
