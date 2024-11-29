using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : SmartHubBaseController
{
    private readonly IUserService _userService;
    private readonly ISessionsService _sessionsService;
    public UserController(IUserService userService, ISessionsService sessionService)
    {
        _userService = userService;
        _sessionsService = sessionService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        if (loginRequest == null)
        {
            throw new ArgumentException("Request not found.");
        }

        User user = _userService.Login(loginRequest.Email, loginRequest.Password);
        var session = _sessionsService.AddSession(user);

        return Ok(session);
    }

    [HttpGet("health-check")]
    public IActionResult HealthCheck()
    {
        return Ok("API is running");
    }

    [HttpGet("homes")]
    [ServiceFilter(typeof(AuthenticationFilterAttribute))]
    [ServiceFilter(typeof(AuthorizationFilterAttribute))]
    public IActionResult GetHomes()
    {
        User user = GetUserLogged();
        var homes = _userService.GetHomes(user);
        return Ok(homes);
    }

    [HttpPatch("profile-photo")]
    [ServiceFilter(typeof(AuthenticationFilterAttribute))]
    [ServiceFilter(typeof(AuthorizationFilterAttribute))]
    public IActionResult ChangeProfilePhoto([FromBody] ProfilePhotoUpdateRequest request)
    {
        NotValidModel();
        User user = GetUserLogged();
        var result = _userService.ChangeProfilePhoto(user, request.Photo);
        return Ok(result);
    }
}
