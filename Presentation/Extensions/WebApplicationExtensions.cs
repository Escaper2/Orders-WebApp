using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Extensions;

public static class WebApplicationExtensions
{
    public static void Migrate(this WebApplication application)
    {
        var serviceScope = application.Services.GetService<IServiceScopeFactory>()?.CreateScope();
        var context = serviceScope.ServiceProvider.GetRequiredService<DatabaseContext>();
        context.Database.MigrateAsync();
    }
}