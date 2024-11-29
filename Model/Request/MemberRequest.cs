namespace SmartHub.Model.Request;

public class MemberRequest
{
    public required string MemberEmail { get; set; }
    public List<string> Permissions { get; set; } = [];
}
