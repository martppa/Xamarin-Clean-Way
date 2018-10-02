using Microsoft.Extensions.DependencyInjection;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;
using xCleanWay.Desktop.Data.Persistence.Serialization.Binary;
using xCleanWay.Di;
using xCleanWay.Remote.RestSharp;

namespace xCleanWay.Mac.Di
{
    /// <summary>
    ///     MacOS project's injector
    /// </summary>
    public class Injector : BusinessInjector
    {
        private static Injector instance;
        
        public static Injector GetInstance()
        {
            return instance ?? (instance = new Injector());
        }

        protected override void AddExtraServices()
        {
            serviceCollection.AddTransient<IRestFramework, RestSharpFramework>(); // <-- Replace the implementation to swap between different REST client framework
            serviceCollection.AddTransient<ISettingsSerializer, SettingsBinarySerializer>();
        }
    }
}