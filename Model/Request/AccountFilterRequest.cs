namespace SmartHub.Model.Request;
public class AccountFilterRequest
{
    public string? Role { get; set; }
    public string? FullName { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
