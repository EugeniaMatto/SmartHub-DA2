using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public class MotionSensorService : IMotionSensorService
{
    private readonly IDeviceService _deviceService;
    private readonly INotificationService _notificationService;

    public MotionSensorService(IDeviceService deviceService, INotificationService notificationService)
    {
        _deviceService = deviceService;
        _notificationService = notificationService;
    }

    public Guid AddMotionSensor(DeviceRequest device, User user)
    {
        var newDevice = new Device
        {
            Name = device.Name,
            Model = device.ModelNumber,
            Type = DeviceType.MotionSensor,
            Description = device.Description,
            Photos = device.Photos
        };

        _deviceService.AddDevice(newDevice, user);
        return newDevice.Id;
    }

    public List<NotificationResponse> MotionDetection(Guid hardwareId)
    {
        var hardware = _deviceService.GetHardwareById(hardwareId);

        if (!hardware.Device.Type.Equals(DeviceType.MotionSensor))
        {
            throw new HardwareNotCompatibleException(hardwareId.ToString(), DeviceType.MotionSensor.ToString());
        }

        return _notificationService.AddNotification(hardwareId, "Motion Sensor Alert: Motion Detection");
    }
}
