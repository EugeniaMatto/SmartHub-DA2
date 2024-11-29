using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface INotificationService
{
    List<NotificationResponse> GetNotifications(Guid? userId, bool? seen);
    List<NotificationResponse> AddNotification(Guid hardwareId, string descripcion);
}
