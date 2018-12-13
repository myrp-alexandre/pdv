using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TOTVS.PDV.Infra.Data.Context;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Infra.Data.Repositories;
using TOTVS.PDV.Services;
using TOTVS.PDV.Services.Contracts;

namespace TOTVS.PDV.Infra.CrossCutting.DI
{
    public static class DIFactory
    {

        //private static DbContextOptions GetOptions(string connectionString)
        //{
        //    return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        //}

        public static IServiceCollection ConfigureDI(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<DbContextPDV>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionConfiguracao")));


            ConfigureApplicationServices(services);
            ConfigureServices(services);
            ConfigureRepository(services);

            return services;
        }

        private static void ConfigureApplicationServices(IServiceCollection services)
        {
      
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFluxoService, FluxoService>();
        }

        private static void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<IDinheiroRepository, DinheiroRepository>(); 
        }
    }
}
