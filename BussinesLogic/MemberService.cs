using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;

public class MemberService : IMemberService
{
    private readonly IHomeService _homeService;

    public MemberService(IHomeService homeService)
    {
        _homeService = homeService;
    }

    public void AddMember(MemberRequest request, string homeId, User user)
    {
        var home = _homeService.GetHomeById(homeId);
        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        if (home.OwnerId != user.Id)
        {
            throw new HomePermissionException(user.Id, "OwnerAction", home.Id);
        }

        var permissions = request.Permissions.ConvertAll(MapHomePermission);
        _homeService.AddMember(request.MemberEmail, homeId, permissions);
    }

    public void AddPermission(string homeId, Guid userId, List<string> permissions, User user)
    {
        var home = _homeService.GetHomeById(homeId);
        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        if (home.OwnerId != user.Id)
        {
            throw new Exception($"Only the owner of the home can perform this action");
        }

        var userHomePermission = _homeService.GetUserHomePermission(homeId, userId);
        if (userHomePermission == null)
        {
            throw new NotFoundException("Member", userId);
        }

        var permissionsMapped = new List<HomePermission>();
        foreach (var permission in permissions)
        {
            var permissionmapped = MapHomePermission(permission);
            if (!userHomePermission.Permissions.Contains(permissionmapped))
            {
                permissionsMapped.Add(permissionmapped);
            }
        }

        userHomePermission.Permissions.AddRange(permissionsMapped);
        _homeService.AddHomePermission(userHomePermission);
    }

    public List<MemberResponse> GetMembers(string homeId)
    {
        var members = _homeService.GetMembers(homeId);
        return members;
    }

    public void AddNotificationMember(string homeId, string memberEmail)
    {
        var home = _homeService.GetHomeById(homeId);
        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        var member = _homeService.GetMemberByEmail(homeId, memberEmail);
        if (member == null && home.Owner.Email != memberEmail)
        {
            throw new NotFoundException("Member", memberEmail);
        }

        _homeService.AddNotificationMember(homeId, memberEmail);
    }

    private HomePermission MapHomePermission(string action)
    {
        if (Enum.TryParse(action, true, out HomePermission parsedPermission))
        {
            return parsedPermission;
        }
        else
        {
            throw new InvalidValueException("HomePermission", action, new { ValidPermissions = Enum.GetNames(typeof(HomePermission)) });
        }
    }
}
