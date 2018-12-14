using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TOTVS.PDV.Infra.Data.Context;

namespace TOTVS.PDV.Host.WebApi.Configurations
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContextPDV>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IApplicationBuilder UseMigrations(this IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                if (env.IsDevelopment())
                {
                    var db = serviceScope.ServiceProvider.GetService<DbContextPDV>();

                    //TODO: Descomentar para a primeira execução ou rodar "update-database" no package manager console
                    //if (!db.Database.EnsureCreated())
                    //{
                    //    db.Database.Migrate();
                    //    db.Database.EnsureCreated();
                    //}
                }
            }

            return app;
        }
    }
}
