using Microsoft.Extensions.DependencyInjection;
using xCleanWay.AndroidData.Persistence.Preferences;
using xCleanWay.Data.Repositories.Providers.Rest;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;
using xCleanWay.Di;
using xCleanWay.Remote.RestSharp.xCleanWay.Remote.RestSharp;

namespace xCleanWay.Android.Di
{
    public class Injector : BusinessInjector
    {
        private static Injector instance;
        
        public static Injector GetInstance()
        {
            return instance ?? (instance = new Injector());
        }

        protected override void AddExtraServices()
        {
            serviceCollection.AddTransient<IRestFramework, RestSharpFramework>();
            serviceCollection.AddTransient<ISettingsSerializer, SettingsPreference>();
        }
    }
}