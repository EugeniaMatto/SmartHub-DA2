using System.Text.Json.Serialization;
using SmartHub.Domain;

namespace SmartHub.Model.Response;
public readonly struct DeviceResponse
{
    public Guid Id { get; }
    public string Name { get; }
    public string Model { get; }
    public string MainPhoto { get; }
    public List<string> Photos { get; }
    public string Type { get; }
    public string Description { get; }
    public string CompanyName { get; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string>? UseTypes { get; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string>? SupportedActions { get; }

    public DeviceResponse(Device device, Company company)
    {
        Id = device.Id;
        Name = device.Name;
        Model = device.Model;
        MainPhoto = device.Photos.FirstOrDefault() ?? string.Empty;
        Photos = device.Photos ?? [];
        Type = device.Type.ToString();
        Description = device.Description;
        CompanyName = company.Name;

        UseTypes = null;
        SupportedActions = null;

        if (device is SecurityCam cameraDevice)
        {
            UseTypes = cameraDevice.UseTypes?.Select(u => u.ToString()).ToList();
            SupportedActions = cameraDevice.CamSupportedActions?.Select(a => a.ToString()).ToList();
        }
    }
}
