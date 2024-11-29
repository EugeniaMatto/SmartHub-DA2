namespace SmartHub.Model.Request;
public class CompanyFilterRequest
{
    public string? CompanyName { get; set; }
    public string? FullName { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
