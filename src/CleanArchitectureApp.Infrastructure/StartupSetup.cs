using CleanArchitectureApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureApp.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(connectionString, b => b.MigrationsAssembly("CleanArchitectureApp.Web")));
        // options.UseSqlite(connectionString)); // will be created in web project root
    }
}
