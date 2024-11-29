using System.Diagnostics.CodeAnalysis;
using SmartHub.BussinesLogic;
using SmartHub.BussinesLogic.deviceImporter;
using SmartHub.BussinesLogic.ModelValidator;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class ServicesConfiguration
{
    public static void Configure(WebApplicationBuilder builder)
    {
        var services = builder.Services;

        services.AddScoped<ISessionsService, SessionsService>();
        services.AddScoped<IPermissionService, PermissionService>();
        services.AddScoped<IHomeService, HomeService>();
        services.AddScoped<IMemberService, MemberService>();
        services.AddScoped<ICompanyService, CompanyService>();
        services.AddScoped<IDeviceService, DeviceService>();
        services.AddScoped<INotificationService, NotificationService>();
        services.AddScoped<IAdministratorService, AdministratorService>();
        services.AddScoped<IHomeOwnerService, HomeOwnerService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ICompanyOwnerService, CompanyOwnerService>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IWindowSensorService, WindowSensorService>();
        services.AddScoped<IMotionSensorService, MotionSensorService>();
        services.AddScoped<ICameraService, CameraService>();
        services.AddScoped<ISmartLampService, SmartLampService>();
        services.AddScoped<IDeviceImporterFactory, DeviceImporterFactory>();
        services.AddScoped<IDeviceModelValidator, DeviceModelValidator>();
    }
}
