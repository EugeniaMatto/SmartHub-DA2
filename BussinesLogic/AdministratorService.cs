using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;

namespace SmartHub.BussinesLogic;
public class AdministratorService : IAdministratorService
{
    private readonly IPermissionService _permissionService;
    private readonly IUserService _userService;

    public AdministratorService(IUserService userService, IPermissionService permissionService)
    {
        _userService = userService;
        _permissionService = permissionService;
    }

    public User CreateAdminAccount(AdministratorRequest newAdmin)
    {
        var admin = new User
        {
            Name = newAdmin.Name,
            Surname = newAdmin.Surname,
            Email = newAdmin.Email,
            Password = newAdmin.Password
        };
        _userService.AddAccount(admin);
        AddAdminPermissions(admin);
        _permissionService.AddNeutralPermissions(admin);
        return admin;
    }

    private void AddAdminPermissions(User admin)
    {
        admin.Roles = admin.Roles.Concat([Role.Administrator]).ToList();
        _userService.UpdateAccount(admin);
        _permissionService.AddUserPermission("createadminaccount-administrator", admin.Email);
        _permissionService.AddUserPermission("deleteadminaccount-administrator", admin.Email);
        _permissionService.AddUserPermission("createcompanyowneraccount-companyowner", admin.Email);
        _permissionService.AddUserPermission("getaccounts-accounts", admin.Email);
        _permissionService.AddUserPermission("getcompany-companies", admin.Email);
        _permissionService.AddUserPermission("addhomeownerpermission-homeowner", admin.Email);
    }

    public void DeleteAdminAccount(Guid accountId)
    {
        var admin = _userService.GetById(accountId.ToString());
        if (admin == null)
        {
            throw new NotFoundException("Administrator", accountId);
        }

        _userService.DeleteAccount(admin, Role.Administrator);
    }
}
