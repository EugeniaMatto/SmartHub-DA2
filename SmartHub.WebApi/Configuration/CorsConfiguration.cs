using System.Diagnostics.CodeAnalysis;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class CorsConfiguration
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowFrontendApp", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
        });
    }
}
