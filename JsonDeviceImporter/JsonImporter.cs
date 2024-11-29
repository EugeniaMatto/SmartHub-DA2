using System.Text.Json;
using SmartHub.BussinesLogic.deviceImporter;
using SmartHub.Domain;

namespace JsonDeviceImporter;
public class JsonImporter : IDeviceImporter
{
    public List<Device> ImportDevices(string source)
    {
        var jsonString = File.ReadAllText(source);
        Console.WriteLine(jsonString);
        var jsonObject = JsonSerializer.Deserialize<JsonDeviceList>(jsonString);

        var devices = new List<Device>();
        foreach (var item in jsonObject.Dispositivos)
        {
            Device device;

            switch (item.Tipo.ToLower())
            {
                case "camera":
                    device = new SecurityCam
                    {
                        Id = Guid.Parse(item.Id),
                        Name = item.Nombre,
                        Model = item.Modelo,
                        Type = DeviceType.SecurityCam,
                        Description = string.Empty,
                        CreatedAt = DateTime.UtcNow,
                        Photos = item.Fotos.Where(f => f.Es_principal).Select(f => f.Path).ToList()
                    };

                    var camSupportedActions = new List<CamSupportedActions>();

                    if (item.Person_Detection == true)
                    {
                        camSupportedActions.Add(CamSupportedActions.PersonDetection);
                    }

                    if (item.Movement_Detection == true)
                    {
                        camSupportedActions.Add(CamSupportedActions.MotionDetection);
                    }

                    ((SecurityCam)device).CamSupportedActions = camSupportedActions;
                    break;

                case "sensor-open-close":
                    device = new Device
                    {
                        Id = Guid.Parse(item.Id),
                        Name = item.Nombre,
                        Model = item.Modelo,
                        Type = DeviceType.WindowSensor,
                        Description = string.Empty,
                        CreatedAt = DateTime.UtcNow,
                        Photos = item.Fotos.Where(f => f.Es_principal).Select(f => f.Path).ToList()
                    };
                    break;

                case "sensor-movement":
                    device = new Device
                    {
                        Id = Guid.Parse(item.Id),
                        Name = item.Nombre,
                        Model = item.Modelo,
                        Type = DeviceType.MotionSensor,
                        Description = string.Empty,
                        CreatedAt = DateTime.UtcNow,
                        Photos = item.Fotos.Where(f => f.Es_principal).Select(f => f.Path).ToList()
                    };
                    break;

                case "smartlamp":
                    device = new Device
                    {
                        Id = Guid.Parse(item.Id),
                        Name = item.Nombre,
                        Model = item.Modelo,
                        Type = DeviceType.SmartLamp,
                        Description = string.Empty,
                        CreatedAt = DateTime.UtcNow,
                        Photos = item.Fotos.Where(f => f.Es_principal).Select(f => f.Path).ToList()
                    };
                    break;

                default:
                    continue;
            }

            devices.Add(device);
        }

        return devices;
    }
}
