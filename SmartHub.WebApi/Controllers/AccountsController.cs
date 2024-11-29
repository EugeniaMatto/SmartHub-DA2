using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/accounts")]
public class AccountsController : SmartHubBaseController
{
    private readonly IAccountService _accountService;

    public AccountsController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public IActionResult GetAccounts([FromQuery] AccountFilterRequest filter)
    {
        var accounts = _accountService.GetAll(filter);
        return Ok(accounts);
    }
}
