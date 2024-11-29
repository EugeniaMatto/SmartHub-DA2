using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.BussinesLogic;
public class HomeOwnerService : IHomeOwnerService
{
    private readonly IPermissionService _permissionService;
    private readonly IUserService _userService;

    public HomeOwnerService(IUserService userService, IPermissionService permissionService)
    {
        _userService = userService;
        _permissionService = permissionService;
    }

    public User CreateHomeOwnerAccount(HomeOwnerRequest newHomeOwner)
    {
        var user = new User
        {
            Name = newHomeOwner.Name,
            Surname = newHomeOwner.Surname,
            Email = newHomeOwner.Email,
            Password = newHomeOwner.Password,
            ProfilePhoto = newHomeOwner.ProfilePhoto
        };
        _userService.AddAccount(user);
        _permissionService.AddNeutralPermissions(user);
        AddPermissionToUser(user);

        return user;
    }

    public void AddPermissionToUser(User user)
    {
        user.Roles = user.Roles.Concat([Role.HomeOwner]).ToList();
        _userService.UpdateAccount(user);
        _permissionService.AddUserPermission("add-home", user.Email);
        _permissionService.AddUserPermission("addmember-members", user.Email);
        _permissionService.AddUserPermission("adddevice-home", user.Email);
        _permissionService.AddUserPermission("getmembers-members", user.Email);
        _permissionService.AddUserPermission("getdevices-home", user.Email);
        _permissionService.AddUserPermission("addnotificationmembers-members", user.Email);
        _permissionService.AddUserPermission("updatenamedevice-home", user.Email);
        _permissionService.AddUserPermission("addmotionsensor-motionsensor", user.Email);
        _permissionService.AddUserPermission("gethomes-user", user.Email);
        _permissionService.AddUserPermission("addpermission-members", user.Email);
        _permissionService.AddUserPermission("getrooms-home", user.Email);
        _permissionService.AddUserPermission("addrooms-home", user.Email);
        _permissionService.AddUserPermission("hardwareoff-home", user.Email);
        _permissionService.AddUserPermission("hardwareon-home", user.Email);
        _permissionService.AddUserPermission("updateroomdevice-home", user.Email);
        _permissionService.AddUserPermission("getemails-homeowner", user.Email);
    }

    public List<string> GetUserEmails()
    {
        return _userService.GetEmails(Role.HomeOwner);
    }
}
