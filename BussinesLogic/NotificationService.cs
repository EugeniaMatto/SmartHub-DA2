using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public class NotificationService : INotificationService
{
    private readonly IRepository<Notification> _notificationRepository;
    private readonly IRepository<Hardware> _hardwareRepository;
    private readonly IRepository<Home> _homeRepository;
    private readonly IRepository<User> _userRepository;

    public NotificationService(
        IRepository<Notification> notificationRepository,
        IRepository<Hardware> hardwareRepository,
        IRepository<Home> homeRepository,
        IRepository<User> userRepository)
    {
        _notificationRepository = notificationRepository;
        _hardwareRepository = hardwareRepository;
        _homeRepository = homeRepository;
        _userRepository = userRepository;
    }

    public List<NotificationResponse> GetNotifications(Guid? userId, bool? seen)
    {
        var notificationsQuery = _notificationRepository.GetAll(null, n => n.User);

        if (userId.HasValue)
        {
            notificationsQuery = notificationsQuery.Where(n => n.UserId == userId);
        }

        if (seen.HasValue)
        {
            notificationsQuery = notificationsQuery.Where(n => n.Seen == seen.Value);
        }

        return notificationsQuery.ToList().ConvertAll(u => new NotificationResponse(u));
    }

    public List<NotificationResponse> AddNotification(Guid hardwareId, string descripcion)
    {
        var hardware = _hardwareRepository.Get(h => h.Id == hardwareId);

        if (hardware.Online == false)
        {
            throw new HardwareFeatureNotSupportedException(hardware.Id.ToString(), "Hardware is OFF");
        }

        var home = _homeRepository.Get(h => h.Id == hardware.HomeId, h => h.NotificationMembers);
        var notificationUserIds = home.NotificationMembers.Select(nm => nm.UserId).ToList();
        var notifications = new List<Notification>();

        foreach (var nmuserId in notificationUserIds)
        {
            var user = _userRepository.Get(u => u.Id == nmuserId);

            if (user != null)
            {
                var notification = new Notification
                {
                    Id = Guid.NewGuid(),
                    Event = descripcion,
                    HardwareId = hardwareId,
                    UserId = nmuserId,
                    UserEmail = user.Email,
                    User = user,
                };

                _notificationRepository.Add(notification);
                notifications.Add(notification);
            }
        }

        return notifications.ConvertAll(u => new NotificationResponse(u));
    }
}
