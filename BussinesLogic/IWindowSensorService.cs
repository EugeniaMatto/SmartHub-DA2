using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface IWindowSensorService
{
    Guid AddSensor(DeviceRequest device, User user);
    List<NotificationResponse> Open(Guid hardwareId);
    List<NotificationResponse> Close(Guid hardwareId);
}
