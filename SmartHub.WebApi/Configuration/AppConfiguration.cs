using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SmartHub.DB;

namespace SmartHub.WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class AppConfiguration
{
    public static void ConfigureApp(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<SmartHubAPIContext>();
            var pendingMigrations = context.Database.GetPendingMigrations();

            if (pendingMigrations.Any())
            {
                context.Database.Migrate();
            }
        }

        app.UseCors("AllowFrontendApp");
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
}
