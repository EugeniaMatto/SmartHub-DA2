using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.BussinesLogic;
public class CompanyOwnerService : ICompanyOwnerService
{
    private readonly IPermissionService _permissionService;
    private readonly IUserService _userService;

    public CompanyOwnerService(IUserService userService, IPermissionService permissionService)
    {
        _userService = userService;
        _permissionService = permissionService;
    }

    public User CreateCompanyOwnerAccount(CompanyOwnerRequest newAccount)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = newAccount.Name,
            Surname = newAccount.Surname,
            Email = newAccount.Email,
            Password = newAccount.Password
        };
        _userService.AddAccount(user);
        AddCompanyOwnerPermissions(user);
        _permissionService.AddNeutralPermissions(user);
        return user;
    }

    private void AddCompanyOwnerPermissions(User user)
    {
        user.Roles = user.Roles.Concat([Role.CompanyOwner]).ToList();
        _userService.UpdateAccount(user);
        _permissionService.AddUserPermission("createcompany-companies", user.Email);
        _permissionService.AddUserPermission("addsensor-windowsensor", user.Email);
        _permissionService.AddUserPermission("addmotionsensor-motionsensor", user.Email);
        _permissionService.AddUserPermission("addcamera-camera", user.Email);
        _permissionService.AddUserPermission("addhomeownerpermission-homeowner", user.Email);
        _permissionService.AddUserPermission("addsmartlamp-smartlamp", user.Email);
        _permissionService.AddUserPermission("getcompanyuser-companies", user.Email);
        _permissionService.AddUserPermission("importdevices-devices", user.Email);
        _permissionService.AddUserPermission("getimporters-devices", user.Email);
        _permissionService.AddUserPermission("getdevicemodelvalidators-devices", user.Email);
        _permissionService.AddUserPermission("selectdevicemodelvalidator-devices", user.Email);
    }
}
