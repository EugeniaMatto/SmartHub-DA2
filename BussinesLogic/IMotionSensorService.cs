using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface IMotionSensorService
{
    Guid AddMotionSensor(DeviceRequest device, User user);
    List<NotificationResponse> MotionDetection(Guid hardwareId);
}
