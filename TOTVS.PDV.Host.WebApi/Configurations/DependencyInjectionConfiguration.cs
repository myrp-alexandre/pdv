using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TOTVS.PDV.Infra.CrossCutting.DI;

namespace TOTVS.PDV.Host.WebApi.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ConfigureDI(this IServiceCollection services, IConfiguration configuration) => DIFactory.ConfigureDI(services, configuration);
    }
}
