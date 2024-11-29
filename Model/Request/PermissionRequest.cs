namespace SmartHub.Model.Request;
public class PermissionRequest
{
    public List<string> Permissions { get; set; } = [];
    public string HomeId { get; set; } = string.Empty;
}
