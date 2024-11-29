using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/company-owners")]
public class CompanyOwnerController : SmartHubBaseController
{
    private readonly ICompanyOwnerService _companyOwnerService;
    private readonly ISessionsService _sessionsService;

    public CompanyOwnerController(ICompanyOwnerService companyOwnerService, ISessionsService sessionsService)
    {
        _companyOwnerService = companyOwnerService;
        _sessionsService = sessionsService;
    }

    [HttpPost]
    public IActionResult CreateCompanyOwnerAccount([FromBody] CompanyOwnerRequest newAccount)
    {
        NotValidModel();

        var user = _companyOwnerService.CreateCompanyOwnerAccount(newAccount);
        var token = _sessionsService.AddSession(user);
        return Ok(new { Token = token });
    }
}
