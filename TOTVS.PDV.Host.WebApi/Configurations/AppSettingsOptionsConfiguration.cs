using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOTVS.PDV.Host.WebApi.Configurations
{
    public static class AppSettingsOptionsConfiguration
    {
        public static WebHostBuilderContext ConfigAppSettingsFiles(this WebHostBuilderContext hostingContext, IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.AddJsonFile("appsettings/appsettings.json", optional: true, reloadOnChange: true);
            configurationBuilder.AddJsonFile($"appsettings/appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);

            return hostingContext;
        }
    }
}
