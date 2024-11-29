namespace SmartHub.Model.Request;

public class DeviceCamRequest : DeviceRequest
{
    public required List<string> UseTypes { get; set; }
    public required List<string> SupportedActions { get; set; }
}
