using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TOTVS.PDV.Infra.Data.Contracts.Repository;
using TOTVS.PDV.Infra.Data.Repository;
using TOTVS.PDV.Services;
using TOTVS.PDV.Services.Contracts;

namespace TOTVS.PDV.Infra.CrossCutting.DI
{
    public static class DIFactory
    {
        public static IServiceCollection ConfigureDI(IServiceCollection services, IConfiguration configuration)
        {
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
