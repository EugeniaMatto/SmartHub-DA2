using System.Diagnostics.CodeAnalysis;
using SmartHub.DataAccess;
using SmartHub.Domain;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class RepositoriesConfiguration
{
    public static void Configure(WebApplicationBuilder builder)
    {
        var services = builder.Services;

        services.AddScoped<IRepository<Company>, Repository<Company>>();
        services.AddScoped<IRepository<User>, Repository<User>>();
        services.AddScoped<IRepository<Hardware>, Repository<Hardware>>();
        services.AddScoped<IRepository<Device>, Repository<Device>>();
        services.AddScoped<IRepository<Notification>, Repository<Notification>>();
        services.AddScoped<IRepository<Home>, Repository<Home>>();
        services.AddScoped<IRepository<Permission>, Repository<Permission>>();
        services.AddScoped<IRepository<UserHomePermission>, Repository<UserHomePermission>>();
        services.AddScoped<IRepository<NotificationMember>, Repository<NotificationMember>>();
        services.AddScoped<IRepository<SessionUser>, Repository<SessionUser>>();
    }
}
