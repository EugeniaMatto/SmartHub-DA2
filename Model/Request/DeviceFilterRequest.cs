using SmartHub.Domain;

namespace SmartHub.Model.Request;
public class DeviceFilterRequest
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public string? CompanyName { get; set; }
    public DeviceType? DeviceType { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
