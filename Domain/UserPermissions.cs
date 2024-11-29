namespace SmartHub.Domain;
public class UserPermissions
{
    public Guid PermissionId { get; set; }
    public Guid UserId { get; set; }

    public virtual User User { get; set; } = null!;
    public virtual Permission Permission { get; set; } = null!;
}
