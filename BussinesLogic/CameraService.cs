using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public class CameraService : ICameraService
{
    private readonly IDeviceService _deviceService;
    private readonly INotificationService _notificationService;

    public CameraService(IDeviceService deviceService, INotificationService notificationService)
    {
        _deviceService = deviceService;
        _notificationService = notificationService;
    }

    public Guid AddCamera(DeviceCamRequest device, User user)
    {
        var newDevice = new SecurityCam
        {
            Name = device.Name,
            Model = device.ModelNumber,
            Type = DeviceType.SecurityCam,
            Description = device.Description,
            Photos = device.Photos
        };

        newDevice.UseTypes = MapUseTypes(device.UseTypes, newDevice);
        newDevice.CamSupportedActions = MapSupportedActions(device.SupportedActions, newDevice);

        _deviceService.AddDevice(newDevice, user);

        return newDevice.Id;
    }

    public List<NotificationResponse> PersonDetection(Guid hardwareId, string? userDetected)
    {
        var hardware = _deviceService.GetHardwareById(hardwareId);

        if (hardware.Device is not SecurityCam securityCam)
        {
            throw new HardwareNotCompatibleException(hardwareId.ToString(), DeviceType.SecurityCam.ToString());
        }

        if (!securityCam.CamSupportedActions.Contains(CamSupportedActions.PersonDetection))
        {
            throw new HardwareFeatureNotSupportedException(hardwareId.ToString(), "PersonDetection", new { SupportedActions = securityCam.CamSupportedActions });
        }

        var description = "Camera Alert: Person detected";
        if (!string.IsNullOrEmpty(userDetected))
        {
            description += $": {userDetected}";
        }

        return _notificationService.AddNotification(hardwareId, description);
    }

    public List<NotificationResponse> MotionDetection(Guid hardwareId)
    {
        var hardware = _deviceService.GetHardwareById(hardwareId);

        if (hardware.Device is not SecurityCam securityCam)
        {
            throw new HardwareNotCompatibleException(hardwareId.ToString(), DeviceType.SecurityCam.ToString());
        }

        if (!securityCam.CamSupportedActions.Contains(CamSupportedActions.MotionDetection))
        {
            throw new HardwareFeatureNotSupportedException(hardwareId.ToString(), "MotionDetection", new { SupportedActions = securityCam.CamSupportedActions });
        }

        return _notificationService.AddNotification(hardwareId, "Camera Alert: Motion detected");
    }

    private List<UseType> MapUseTypes(List<string> useTypes, SecurityCam securityCam)
    {
        var mappedUseTypes = new List<UseType>();
        foreach (var useType in useTypes)
        {
            if (Enum.TryParse(useType, true, out UseType parsedUseType))
            {
                mappedUseTypes.Add(parsedUseType);
            }
            else
            {
                throw new HardwareFeatureNotSupportedException(securityCam.Id.ToString(), useType, new { SupportedActions = securityCam.UseTypes });
            }
        }

        return mappedUseTypes;
    }

    private List<CamSupportedActions> MapSupportedActions(List<string> supportedActions, SecurityCam securityCam)
    {
        var mappedSupportedActions = new List<CamSupportedActions>();
        foreach (var action in supportedActions)
        {
            if (Enum.TryParse(action, true, out CamSupportedActions parsedAction))
            {
                mappedSupportedActions.Add(parsedAction);
            }
            else
            {
                throw new HardwareFeatureNotSupportedException(securityCam.Id.ToString(), action, new { SupportedActions = securityCam.CamSupportedActions });
            }
        }

        return mappedSupportedActions;
    }
}
