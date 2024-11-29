using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/members")]
public class MembersController : SmartHubBaseController
{
    private readonly IMemberService _memberService;

    public MembersController(IMemberService memberService)
    {
        _memberService = memberService;
    }

    [HttpPatch("{homeId}/notification")]
    public IActionResult AddNotificationMembers(string homeId, [FromBody] List<string> emails)
    {
        foreach (var email in emails)
        {
            _memberService.AddNotificationMember(homeId, email);
        }

        return Ok(new { Message = "Notification members added successfully." });
    }

    [HttpGet]
    public IActionResult GetMembers([FromQuery] string homeId)
    {
        var members = _memberService.GetMembers(homeId);
        return Ok(members);
    }

    [HttpPut("{memberId}/permissions")]
    public IActionResult AddPermission(Guid memberId, [FromBody] PermissionRequest request)
    {
        NotValidModel();

        var user = GetUserLogged();
        _memberService.AddPermission(request.HomeId, memberId, request.Permissions, user);

        return Ok(new { Message = "Permissions added successfully." });
    }

    [HttpPost]
    public IActionResult AddMember([FromQuery] string homeId, [FromBody] MemberRequest request)
    {
        NotValidModel();

        var user = GetUserLogged();
        _memberService.AddMember(request, homeId, user);

        return Ok(new { Message = "Member added successfully." });
    }
}
