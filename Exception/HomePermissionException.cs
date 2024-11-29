namespace SmartHub.Exceptions;
public class HomePermissionException : SmartHubBaseException
{
    public Guid UserId { get; }
    public string Permission { get; }
    public Guid HomeId { get; }

    public HomePermissionException(Guid userId, string permission, Guid homeId, object? additionalData = null, Exception? innerException = null)
        : base($"User with ID '{userId}' does not have the required permission '{permission}' for Home with ID '{homeId}'.", "HOME_PERMISSION_DENIED", additionalData, innerException)
    {
        UserId = userId;
        Permission = permission;
        HomeId = homeId;
    }
}
