using System.Diagnostics.CodeAnalysis;
using SmartHub.WebApi.Filters;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class ControllersConfiguration
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.AddControllers(options =>
        {
            options.Filters.Add<ExceptionFilter>();
        })
        .ConfigureApiBehaviorOptions(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });
    }
}
