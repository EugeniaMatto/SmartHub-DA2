namespace SmartHub.Model.Response;
public readonly struct ImportDevicesResponse
{
    public int Total { get; }
    public List<DeviceResponse> Devices { get; }

    public ImportDevicesResponse(int total, List<DeviceResponse> devices)
    {
        Total = total;
        Devices = devices ?? [];
    }
}
