using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface ICameraService
{
    Guid AddCamera(DeviceCamRequest device, User user);
    List<NotificationResponse> PersonDetection(Guid hardwareId, string? userDetected);
    List<NotificationResponse> MotionDetection(Guid hardwareId);
}
