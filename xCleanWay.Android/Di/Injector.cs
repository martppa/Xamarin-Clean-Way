using Microsoft.Extensions.DependencyInjection;
using xCleanWay.AndroidData.Persistence.Preferences;
using xCleanWay.Data.Repositories.Cache;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;
using xCleanWay.Di;
using xCleanWay.iOSData.Persistence.Cache.Country;
using xCleanWay.Remote.RestSharp;

namespace xCleanWay.Android.Di
{
    /// <summary>
    ///     Android project's injector
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
            serviceCollection.AddTransient<ISettingsSerializer, SettingsPreference>();
        }
    }
}