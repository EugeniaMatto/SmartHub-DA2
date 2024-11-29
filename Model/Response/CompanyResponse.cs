namespace SmartHub.Model.Response;
public readonly struct CompanyResponse
{
    public string Name { get; }
    public string LogoURL { get; }
    public string Rut { get; }
    public List<DeviceResponse> Devices { get; }
    public string DeviceModelValidator { get; }

    public CompanyResponse(string name, string logoURL, string rut, List<DeviceResponse> devices, string deviceModelValidator)
    {
        Name = name;
        LogoURL = logoURL;
        Rut = rut;
        Devices = devices ?? [];
        DeviceModelValidator = deviceModelValidator;
    }
}
