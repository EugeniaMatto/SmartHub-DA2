using SmartHub.Domain;

namespace SmartHub.Model.Response;
public class NotificationResponse
{
    public Guid Id { get; set; }
    public string Event { get; set; }
    public bool Seen { get; set; }
    public string User { get; set; }

    public NotificationResponse(Notification notification)
    {
        Id = notification.Id;
        Event = notification.Event;
        Seen = notification.Seen;
        User = notification.UserEmail;
    }
}
