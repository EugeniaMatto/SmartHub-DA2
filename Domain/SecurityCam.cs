namespace SmartHub.Domain;
public class SecurityCam : Device
{
    public List<UseType> UseTypes { get; set; } = [];
    public List<CamSupportedActions> CamSupportedActions { get; set; } = [];
}
