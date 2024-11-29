namespace SmartHub.Model.Request;

public class RequestHardware
{
    public string? Name { get; set; }
    public string DeviceId { get; set; } = null!;
    public string? Room { get; set; }
}
