using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public class SmartLampService : ISmartLampService
{
    private readonly IDeviceService _deviceService;
    private readonly INotificationService _notificationService;

    public SmartLampService(IDeviceService deviceService, INotificationService notificationService)
    {
        _deviceService = deviceService;
        _notificationService = notificationService;
    }

    public Guid AddSmartLamp(DeviceRequest device, User user)
    {
        var newDevice = new Device
        {
            Name = device.Name,
            Model = device.ModelNumber,
            Type = DeviceType.SmartLamp,
            Description = device.Description,
            Photos = device.Photos
        };

        _deviceService.AddDevice(newDevice, user);
        return newDevice.Id;
    }

    public List<NotificationResponse> On(Guid hardwareId)
    {
        var hardware = _deviceService.GetHardwareById(hardwareId);

        if (!hardware.Device.Type.Equals(DeviceType.SmartLamp))
        {
            throw new HardwareNotCompatibleException(hardwareId.ToString(), DeviceType.SmartLamp.ToString());
        }

        var smartLamp = hardware as SmartLampHardware;

        if (smartLamp!.IsOn)
        {
            throw new HardwareFeatureNotSupportedException(hardwareId.ToString(), "Already ON");
        }

        smartLamp.IsOn = true;
        _deviceService.UpdateHardware(smartLamp);
        return _notificationService.AddNotification(hardwareId, "Smart Lamp Alert: ON");
    }

    public List<NotificationResponse> Off(Guid hardwareId)
    {
        var hardware = _deviceService.GetHardwareById(hardwareId);

        if (!hardware.Device.Type.Equals(DeviceType.SmartLamp))
        {
            throw new HardwareNotCompatibleException(hardwareId.ToString(), DeviceType.SmartLamp.ToString());
        }

        var smartLamp = hardware as SmartLampHardware;

        if (!smartLamp!.IsOn)
        {
            throw new HardwareFeatureNotSupportedException(hardwareId.ToString(), "Already OFF");
        }

        smartLamp.IsOn = false;
        _deviceService.UpdateHardware(smartLamp);
        return _notificationService.AddNotification(hardwareId, "Smart Lamp Alert: OFF");
    }
}
