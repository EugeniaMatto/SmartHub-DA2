using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public class WindowSensorService : IWindowSensorService
{
    private readonly IDeviceService _deviceService;
    private readonly INotificationService _notificationService;

    public WindowSensorService(IDeviceService deviceService, INotificationService notificationService)
    {
        _deviceService = deviceService;
        _notificationService = notificationService;
    }

    public Guid AddSensor(DeviceRequest device, User user)
    {
        var newDevice = new Device
        {
            Name = device.Name,
            Model = device.ModelNumber,
            Type = DeviceType.WindowSensor,
            Description = device.Description,
            Photos = device.Photos
        };

        _deviceService.AddDevice(newDevice, user);
        return newDevice.Id;
    }

    public List<NotificationResponse> Open(Guid hardwareId)
    {
        var hardware = _deviceService.GetHardwareById(hardwareId);

        if (!hardware.Device.Type.Equals(DeviceType.WindowSensor))
        {
            throw new HardwareNotCompatibleException(hardwareId.ToString(), DeviceType.WindowSensor.ToString());
        }

        var windowSensor = hardware as WindowSensorHardware;

        if (windowSensor!.IsOpen)
        {
            throw new HardwareFeatureNotSupportedException(hardwareId.ToString(), "Already OPEN");
        }

        windowSensor.IsOpen = true;
        _deviceService.UpdateHardware(windowSensor);
        return _notificationService.AddNotification(hardwareId, "Window Sensor Alert: Open");
    }

    public List<NotificationResponse> Close(Guid hardwareId)
    {
        var hardware = _deviceService.GetHardwareById(hardwareId);

        if (!hardware.Device.Type.Equals(DeviceType.WindowSensor))
        {
            throw new HardwareNotCompatibleException(hardwareId.ToString(), DeviceType.WindowSensor.ToString());
        }

        var windowSensor = hardware as WindowSensorHardware;

        if (!windowSensor!.IsOpen)
        {
            throw new HardwareFeatureNotSupportedException(hardwareId.ToString(), "Already CLOSE");
        }

        windowSensor.IsOpen = false;
        _deviceService.UpdateHardware(windowSensor);
        return _notificationService.AddNotification(hardwareId, "Window Sensor Alert: Closed");
    }
}
