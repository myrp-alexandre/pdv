using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace TOTVS.PDV.Host.WebApi.Configurations
{
    public static class MvcOptionsConfiguration
    {
        public static MvcOptions ConfigureMvcOptions(this MvcOptions options, IConfiguration configuration)
        {
            //options.ConfigureFilters(configuration);
            //options.ConfigureModelinders();

            return options;
        }

        public static MvcOptions ConfigureModelinders(this MvcOptions options)
        {
            //options.ModelBinderProviders.Insert(0, new CurrentCultureDateTimeBinderProvider());
            //options.ModelBinderProviders.Insert(0, new CurrentCultureDecimalBinderProvider());

            return options;
        }

        public static MvcJsonOptions ConfigureMvcJsonOptions(this MvcJsonOptions options, IConfiguration configuration)
        {
            return options.ConfigureSerializersSetttings();
        }

        public static MvcJsonOptions ConfigureSerializersSetttings(this MvcJsonOptions options)
        {
            JsonSerializerSettings settings = options.SerializerSettings;

            //options.SerializerSettings.Converters.Add(new JsonDecimalConverterHelper());
            //options.SerializerSettings.Converters.Add(new JsonDatetimeConverterHelper());

            return options;
        }
    }
}
