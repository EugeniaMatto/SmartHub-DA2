using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface ISmartLampService
{
    Guid AddSmartLamp(DeviceRequest device, User user);
    List<NotificationResponse> On(Guid hardwareId);
    List<NotificationResponse> Off(Guid hardwareId);
}
