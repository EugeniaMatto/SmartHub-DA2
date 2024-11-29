using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(ExceptionFilter))]
[ApiController]
[Route("api/home-owners")]
public class HomeOwnerController : SmartHubBaseController
{
    private readonly IHomeOwnerService _homeOwnerService;
    private readonly ISessionsService _sessionsService;

    public HomeOwnerController(IHomeOwnerService homeOwnerService, ISessionsService sessionsService)
    {
        _homeOwnerService = homeOwnerService;
        _sessionsService = sessionsService;
    }

    [HttpPost]
    [AllowAnonymous]
    public IActionResult CreateHomeOwnerAccount([FromBody] HomeOwnerRequest newHomeOwner)
    {
        NotValidModel();

        var user = _homeOwnerService.CreateHomeOwnerAccount(newHomeOwner);
        var session = _sessionsService.AddSession(user);
        return Ok(session);
    }

    [HttpPost("permissions")]
    [ServiceFilter(typeof(AuthenticationFilterAttribute))]
    [ServiceFilter(typeof(AuthorizationFilterAttribute))]
    public IActionResult AddHomeOwnerPermission()
    {
        var user = GetUserLogged();
        _homeOwnerService.AddPermissionToUser(user);
        return Ok(new { msg = "Permissions added successfully." });
    }

    [HttpGet("emails")]
    [ServiceFilter(typeof(AuthenticationFilterAttribute))]
    [ServiceFilter(typeof(AuthorizationFilterAttribute))]
    public IActionResult GetEmails()
    {
        var response = _homeOwnerService.GetUserEmails();
        return Ok(response);
    }
}
