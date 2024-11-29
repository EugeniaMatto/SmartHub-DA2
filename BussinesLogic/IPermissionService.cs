using SmartHub.Domain;

namespace SmartHub.BussinesLogic;

public interface IPermissionService
{
    public void AddPermission(string permissionName);
    public void AddUserPermission(string permissionName, string userEmail);
    public bool UserHasPermission(string userEmail, string permission);
    public void AddNeutralPermissions(User user);
}
