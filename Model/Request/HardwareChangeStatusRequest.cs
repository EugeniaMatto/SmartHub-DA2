namespace SmartHub.Model.Request;
public class HardwareChangeStatusRequest
{
    public string HardwareId { get; set; } = null!;
    public string HomeId { get; set; } = null!;
}
