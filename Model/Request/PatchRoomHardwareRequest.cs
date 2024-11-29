namespace SmartHub.Model.Request;
public class PatchRoomHardwareRequest
{
    public string Room { get; set; } = null!;
    public string HardwareId { get; set; } = null!;
}
