using Microsoft.Extensions.DependencyInjection;
using xCleanWay.Core.Interactors.Country;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Data.Entities.Mappers;
using xCleanWay.Data.Repositories;
using xCleanWay.Data.Repositories.DataSources;
using xCleanWay.Data.Repositories.DataSources.Suppliers;
using xCleanWay.Data.Repositories.DataStores.Providers;
using xCleanWay.Data.Threading;
using xCleanWay.Remote.Providers.Rest.Country;
using xCleanWay.Data.Repositories.DataSources.Factory;
using xCleanWay.Data.Repositories.DataSources.Network;
using xCleanWay.Data.Repositories.Providers.Country;
using xCleanWay.Data.Repositories.Providers.Country.Rest.Host.RestCountries;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest;
using xCleanWay.Data.Repositories.Providers.Settings;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;
using xCleanWay.Desktop.Data.Persistence.Serialization.Binary;
using xCleanWay.Di;
using xCleanWay.Remote.RestSharp.xCleanWay.Remote.RestSharp;
using xCleanWay.Ui.Models.Mapper;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Presenters.Country;
using xCleanWay.Ui.Threading;

namespace xCleanWay.Mac.Di
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
            serviceCollection.AddTransient<ISettingsSerializer, SettingsBinarySerializer>();
        }
    }
}