using Microsoft.Extensions.DependencyInjection;
using xCleanWay.Data.Repositories.Cache;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;
using xCleanWay.Desktop.Data.Persistence.Cache.Country;
using xCleanWay.Desktop.Data.Persistence.Serialization.Binary;
using xCleanWay.Di;
using xCleanWay.Remote.RestSharp;

namespace xCleanWay.Gtk.Di
{
    /// <summary>
    /// Gtk project's injector
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
            serviceCollection.AddTransient<ICountryCache, CountryCustomCache>();
            serviceCollection.AddTransient<IRestFramework, RestSharpFramework>(); // <-- Replace the implementation to swap between different REST client framework
            serviceCollection.AddTransient<ISettingsSerializer, SettingsBinarySerializer>();
        }
    }
}