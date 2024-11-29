using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SmartHub.DB;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class DatabaseConfiguration
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<SmartHubAPIContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SmartHub")));
    }
}
