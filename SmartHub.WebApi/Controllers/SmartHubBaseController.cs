using Microsoft.AspNetCore.Mvc;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(ExceptionFilter))]
[ApiController]
[Route("api")]
public class SmartHubBaseController
    : ControllerBase
{
    private readonly HttpContext _context;

    public SmartHubBaseController()
    {
        _context = ControllerContext.HttpContext;
    }

    protected User GetUserLogged()
    {
        var userLogged = HttpContext.Items[Item.UserLogged];

        var userLoggedMapped = (User)userLogged!;

        return userLoggedMapped!;
    }

    protected void NotValidModel()
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState
                .Where(e => e.Value!.Errors.Count > 0)
                .ToDictionary(
                    e => e.Key,
                    e => e.Value!.Errors.Select(x => x.ErrorMessage).ToArray());

            throw new ValidationException("The request is invalid.", errors);
        }
    }
}
