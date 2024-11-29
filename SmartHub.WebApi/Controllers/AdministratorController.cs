using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/administrators")]
public class AdministratorController : SmartHubBaseController
{
    private readonly IAdministratorService _administratorService;

    private readonly ISessionsService _sessionsService;

    public AdministratorController(IAdministratorService administratorService, ISessionsService sessionsService)
    {
        _administratorService = administratorService;
        _sessionsService = sessionsService;
    }

    [HttpPost]
    public IActionResult CreateAdminAccount([FromBody] AdministratorRequest newAdmin)
    {
        NotValidModel();
        var user = _administratorService.CreateAdminAccount(newAdmin);
        var session = _sessionsService.AddSession(user);
        return Ok(session);
    }

    [HttpDelete("{accountId}")]
    public IActionResult DeleteAdminAccount(Guid accountId)
    {
        _administratorService.DeleteAdminAccount(accountId);
        var message = $"Deleted Admin account: {accountId}";
        return Ok(new { message });
    }
}
