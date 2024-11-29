using System.Diagnostics.CodeAnalysis;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public class ProgramConfiguration
{
    public static void Run(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ServiceConfiguration.ConfigureServices(builder);

        var app = builder.Build();

        AppConfiguration.ConfigureApp(app);

        app.Run();
    }
}
