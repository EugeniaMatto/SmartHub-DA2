using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;

namespace SmartHub.BussinesLogic;
public sealed class PermissionService : IPermissionService
{
    private readonly IRepository<Permission> _permissionRepository;
    private readonly IRepository<User> _userRepository;

    public PermissionService(
        IRepository<Permission> permissionRepository,
        IRepository<User> userRepository)
    {
        _permissionRepository = permissionRepository;
        _userRepository = userRepository;
    }

    public void AddPermission(string permissionName)
    {
        AddPermissionToDB(permissionName);
    }

    public Permission AddPermissionToDB(string permissionName)
    {
        var permission = _permissionRepository.GetOrDefault(p => p.Name == permissionName);
        if (permission == null)
        {
            permission = new Permission(permissionName);
            _permissionRepository.Add(permission);
        }

        return permission;
    }

    public void AddUserPermission(string permissionName, string userEmail)
    {
        var user = _userRepository.Get(
            u => u.Email == userEmail,
            u => u.Permissions);

        var permission = _permissionRepository.GetOrDefault(p => p.Name == permissionName);
        if (permission == null)
        {
            permission = AddPermissionToDB(permissionName);
        }

        if (!user.HasPermission(permission))
        {
            user.AddPermission(permission);
            user.AddPermission(permission);
            _userRepository.Update(user);
        }
    }

    public bool UserHasPermission(string userEmail, string permission)
    {
        var user = _userRepository.GetOrDefault(
            u => u.Email == userEmail,
            u => u.Permissions);

        if (user == null)
        {
            throw new NotFoundException("User", userEmail);
        }

        var p = _permissionRepository.GetOrDefault(p => p.Name == permission);
        return p != null ? user.HasPermission(p) : false;
    }

    public void AddNeutralPermissions(User user)
    {
        AddUserPermission("getnotifications-notification", user.Email);
        AddUserPermission("open-windowsensor", user.Email);
        AddUserPermission("close-windowsensor", user.Email);
        AddUserPermission("motiondetection-camera", user.Email);
        AddUserPermission("persondetection-camera", user.Email);
        AddUserPermission("getdevices-devices", user.Email);
        AddUserPermission("getdevicetypes-devicetype", user.Email);
        AddUserPermission("motiondetection-motionsensor", user.Email);
        AddUserPermission("on-smartlamp", user.Email);
        AddUserPermission("off-smartlamp", user.Email);
        AddUserPermission("getpermissions-home", user.Email);
        AddUserPermission("changeprofilephoto-user", user.Email);
    }
}
