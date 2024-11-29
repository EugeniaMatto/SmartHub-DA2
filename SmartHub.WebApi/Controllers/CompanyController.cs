using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/companies")]
public class CompaniesController : SmartHubBaseController
{
    private readonly ICompanyService _companyService;

    public CompaniesController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpPost]
    public IActionResult CreateCompany([FromBody] CompanyRequest request)
    {
        NotValidModel();

        var user = GetUserLogged();
        var id = _companyService.CreateCompany(request, user);

        return Ok(new { id });
    }

    [HttpGet]
    public IActionResult GetCompany([FromQuery] CompanyFilterRequest filter)
    {
        var companies = _companyService.GetAllCompanies(filter);
        return Ok(companies);
    }

    [HttpGet("user")]
    public IActionResult GetCompanyUser()
    {
        var user = GetUserLogged();
        return Ok(_companyService.GetCompany(user));
    }
}
