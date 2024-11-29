using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using SmartHub.BussinesLogic;
using SmartHub.Domain;
namespace SmartHub.WebApi.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class AuthenticationFilterAttribute
        : Attribute,
        IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var authorizationHeader = context.HttpContext.Request.Headers[HeaderNames.Authorization];

        if (string.IsNullOrEmpty(authorizationHeader))
        {
            context.Result = new ObjectResult(new
            {
                InnerCode = "Unauthenticated",
                Message = "You are not authenticated"
            })
            {
                StatusCode = (int)HttpStatusCode.Unauthorized
            };
            return;
        }

        var isAuthorizationFormatNotValid = !IsAuthorizationFormatValid(authorizationHeader!);
        if (isAuthorizationFormatNotValid)
        {
            context.Result = new ObjectResult(
                new
                {
                    InnerCode = "InvalidAuthorization",
                    Message = "The provided authorization header format is invalid"
                })
            {
                StatusCode = (int)HttpStatusCode.Unauthorized
            };
            return;
        }

        var isAuthorizationExpired = IsAuthorizationExpired(authorizationHeader!, context);
        if (isAuthorizationExpired)
        {
            context.Result = new ObjectResult(
                new
                {
                    InnerCode = "ExpiredAuthorization",
                    Message = "The provided authorization header is expired"
                })
            {
                StatusCode = (int)HttpStatusCode.Unauthorized
            };
            return;
        }

        try
        {
            var userOfAuthorization = GetUserOfAuthorization(authorizationHeader!, context);
            context.HttpContext.Items[Item.UserLogged] = userOfAuthorization;
        }
        catch (Exception e)
        {
            context.Result = new ObjectResult(new
            {
                InnerCode = "InternalError",
                Message = "An error ocurred while processing the request: " + e.Message
            })
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };
        }
    }

    private bool IsAuthorizationFormatValid(string authorization)
    {
        if (authorization.Length != 36)
        {
            return false;
        }

        var dashCount = authorization.Count(c => c == '-');
        if (dashCount != 4)
        {
            return false;
        }

        foreach (var c in authorization.Replace("-", string.Empty))
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }
        }

        return true;
    }

    private bool IsAuthorizationExpired(
        string authorization,
        AuthorizationFilterContext context)
    {
        var sessionService = context.HttpContext.RequestServices.GetRequiredService<ISessionsService>();
        return sessionService.ExpiredSession(authorization);
    }

    private User GetUserOfAuthorization(
        string authorization,
        AuthorizationFilterContext context)
    {
        var sessionService = context.HttpContext.RequestServices.GetRequiredService<ISessionsService>();

        var user = sessionService.GetUserByToken(authorization);

        return user;
    }
}
