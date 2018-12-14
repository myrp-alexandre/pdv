using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TOTVS.PDV.Application.Services;
using TOTVS.PDV.Application.Services.Contracts;
using TOTVS.PDV.Infra.Data.Contracts.Repositories;
using TOTVS.PDV.Infra.Data.Repositories;
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
            services.AddScoped<IDinheiroApplicationService, DinheiroApplicationService>();
            services.AddScoped<ITransacaoApplicationService, TransacaoApplicationService>();            
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ITransacaoService, TransacaoService>();
            services.AddScoped<IDinheiroService, DinheiroService>();
        }

        private static void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<IDinheiroRepository, DinheiroRepository>();
            services.AddScoped<ITransacaoRepository, TransacaoRepository>();
            services.AddScoped<ITrocoRepository, TrocoRepository>();
            
        }
    }
}
