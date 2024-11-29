using System.Text.Json.Serialization;
using SmartHub.Domain;

namespace SmartHub.Model.Response;
public readonly struct HardwareResponse
{
    public Guid Id { get; }
    public string Name { get; }
    public bool Online { get; }
    public DeviceResponse DeviceInfo { get; }
    public string? Room { get; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? IsOn { get; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? IsOpen { get; }

    public HardwareResponse(Hardware hardware)
    {
        Id = hardware.Id;
        Name = hardware.Name;
        Online = hardware.Online;
        DeviceInfo = new DeviceResponse(hardware.Device, hardware.Device.Company);
        Room = hardware.Room;
        IsOn = null;
        IsOpen = null;

        if (hardware.Device.Type == DeviceType.SmartLamp && hardware is SmartLampHardware smartLamp)
        {
            IsOn = smartLamp.IsOn;
        }

        if (hardware.Device.Type == DeviceType.WindowSensor && hardware is WindowSensorHardware windowSensor)
        {
            IsOpen = windowSensor.IsOpen;
        }
    }
}
