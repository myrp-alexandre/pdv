using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using TOTVS.PDV.Host.WebApi.Configurations;

namespace TOTVS.PDV.Host.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .ConfigureAppConfiguration((hostingContext, config) => hostingContext.ConfigAppSettingsFiles(config))
                .Build();
    }
}
