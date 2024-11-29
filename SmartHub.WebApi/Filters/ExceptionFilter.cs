using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using SmartHub.Exceptions;

namespace SmartHub.WebApi.Filters;

public sealed class ExceptionFilter : IExceptionFilter
{
    private readonly Dictionary<Type, IActionResult> _errors = new()
        {
            {
                typeof(ArgumentNullException),
                new ObjectResult(new
                {
                    InnerCode = "InvalidArgument",
                    Message = "Argument can not be null or empty"
                })
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                }
            },
            {
                typeof(ArgumentException),
                new ObjectResult(new
                {
                    InnerCode = "InvalidArgument",
                    Message = "Argument is invalid"
                })
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                }
            },
            {
                typeof(InvalidOperationException),
                new ObjectResult(new
                {
                    InnerCode = "InvalidOperation",
                    Message = "Operation is not valid"
                })
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                }
            },
            {
                typeof(UnauthorizedAccessException),
                new ObjectResult(new
                {
                    InnerCode = "Unauthorized",
                    Message = "Access is denied"
                })
                {
                    StatusCode = (int)HttpStatusCode.Unauthorized
                }
            },
            {
                typeof(TimeoutException),
                new ObjectResult(new
                {
                    InnerCode = "Timeout",
                    Message = "The request timed out"
                })
                {
                    StatusCode = (int)HttpStatusCode.RequestTimeout
                }
            },
            {
                typeof(DbUpdateException),
                new ObjectResult(new
                {
                    InnerCode = "DatabaseError",
                    Message = "An error occurred while updating the database"
                })
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                }
            },
            {
                typeof(Exception),
                new ObjectResult(new
                {
                    InnerCode = "ServerError",
                    Message = "An unexpected error occurred"
                })
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                }
            }
        };

    public void OnException(ExceptionContext context)
    {
        if (context.Exception is SmartHubBaseException smartHubException)
        {
            context.Result = new ObjectResult(new
            {
                InnerCode = smartHubException.ErrorCode,
                smartHubException.Message
            })
            {
                StatusCode = (int)HttpStatusCode.BadRequest
            };
            context.ExceptionHandled = true;
            return;
        }

        var response = _errors.GetValueOrDefault(context.Exception.GetType());

        if (response == null)
        {
            context.Result = new ObjectResult(new
            {
                InnerCode = "InternalError",
                Message = "There was an error when processing the request: " + context.Exception.Message
            })
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };
            return;
        }

        context.Result = response;
    }
}
