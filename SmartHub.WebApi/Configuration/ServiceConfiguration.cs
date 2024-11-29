using System.Diagnostics.CodeAnalysis;

namespace SmartHub.WebApi.Configuration;
[ExcludeFromCodeCoverage]
public static class ServiceConfiguration
{
    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        CorsConfiguration.Configure(builder);
        DatabaseConfiguration.Configure(builder);
        ControllersConfiguration.Configure(builder);
        ServicesConfiguration.Configure(builder);
        RepositoriesConfiguration.Configure(builder);
        FiltersConfiguration.Configure(builder);
    }
}
