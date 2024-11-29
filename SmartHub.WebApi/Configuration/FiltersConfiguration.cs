using System.Diagnostics.CodeAnalysis;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class FiltersConfiguration
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<AuthenticationFilterAttribute>();
        builder.Services.AddScoped<AuthorizationFilterAttribute>();
        builder.Services.AddScoped<ExceptionFilter>();
    }
}
