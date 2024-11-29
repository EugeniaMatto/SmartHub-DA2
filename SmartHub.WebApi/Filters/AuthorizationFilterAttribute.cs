using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SmartHub.BussinesLogic;
using SmartHub.Domain;

namespace SmartHub.WebApi.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class AuthorizationFilterAttribute(string? permission = null)
       : Attribute,
       IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (context.Result != null)
        {
            return;
        }

        var userLogged = context.HttpContext.Items[Item.UserLogged];

        var userIsNotIdentified = userLogged == null;
        if (userIsNotIdentified)
        {
            context.Result = new ObjectResult(new
            {
                InnerCode = "UnAuthorized",
                Message = $"Not authenticated"
            });
            return;
        }

        var userLoggedMapped = (User)userLogged;

        var permission = BuildPermission(context);

        var hasNotPermission = !UserHasPermission(userLoggedMapped!, permission, context);

        if (hasNotPermission)
        {
            context.Result = new ObjectResult(new
            {
                InnerCode = "Forbidden",
                Message = $"Missing permission {permission}"
            })
            {
                StatusCode = (int)HttpStatusCode.Forbidden
            };
        }
    }

    private string BuildPermission(AuthorizationFilterContext context)
    {
        return permission ?? $"{context.RouteData.Values["action"].ToString().ToLower()}-{context.RouteData.Values["controller"].ToString().ToLower()}";
    }

    private bool UserHasPermission(User user, string permission, AuthorizationFilterContext context)
    {
        var sessionService = context.HttpContext.RequestServices.GetRequiredService<IPermissionService>();
        return sessionService.UserHasPermission(user.Email, permission);
    }
}
