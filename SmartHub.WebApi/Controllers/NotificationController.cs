using Microsoft.AspNetCore.Mvc;
using SmartHub.BussinesLogic;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Controllers;

[ServiceFilter(typeof(AuthenticationFilterAttribute))]
[ServiceFilter(typeof(AuthorizationFilterAttribute))]
[ApiController]
[Route("api/notifications")]
public class NotificationController : SmartHubBaseController
{
    private readonly INotificationService notificationService;

    public NotificationController(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    [HttpGet]
    public IActionResult GetNotifications(Guid? user_id, bool? seen)
    {
        var notifications = notificationService.GetNotifications(user_id, seen);
        return Ok(notifications);
    }
}
