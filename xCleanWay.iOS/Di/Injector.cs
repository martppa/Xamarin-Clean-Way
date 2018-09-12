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
using xCleanWay.Persistence.Disk.Serialization;
using xCleanWay.Persistence.Providers;
using xCleanWay.Persistence.RawModels.Mappers;
using xCleanWay.Remote.DataSources;
using xCleanWay.Remote.Net;
using xCleanWay.Remote.Providers.Rest;
using xCleanWay.Remote.Providers.Rest.Country;
using xCleanWay.Remote.Providers.Rest.Hosts.RestCountries;
using xCleanWay.Remote.RawModels.Mappers;
using xCleanWay.CommonRemote.RestSharp;
using xCleanWay.iOSData.Persistence.Settings;
using xCleanWay.Ui.Models.Mapper;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Presenters.Country;
using xCleanWay.Ui.Threading;

namespace xCleanWay.iOS.Di
{
    public class Injector
    {
        private static Injector instance;
        private ServiceCollection serviceCollection;
        private ServiceProvider serviceProvider;

        private Injector()
        {
            InitializeInjector();
        }

        private void InitializeInjector()
        {
            serviceCollection = new ServiceCollection();
            AddPlatformDataServices();
            AddRemoteServices();
            AddPersistenceServices();
            AddDataServices();
            AddBusinessServices();
            AddUiServices();
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void AddPlatformDataServices()
        {
            serviceCollection.AddTransient<IRestFramework, RestSharpFramework>();
            serviceCollection.AddTransient<ISettingsSerializer, SettingsPreference>();
        }

        private void AddRemoteServices()
        {
            serviceCollection.AddTransient<RawCountryMapper>();
            serviceCollection.AddTransient<ICountryRestApi, RestCountriesCountryRestApi>();
            serviceCollection.AddTransient<ICountryProvider, CountryRestProvider>();
        }

        private void AddPersistenceServices()
        {
            serviceCollection.AddTransient<RawSettingsMapper>();
            serviceCollection.AddTransient<ISettingsProvider, SettingsDiskProvider>();
        }

        private void AddDataServices()
        {
            serviceCollection.AddTransient<IDataThread, DataThread>();
            serviceCollection.AddTransient<ICountryDataSource, CountryNetworkDataSource>();
            serviceCollection.AddTransient<ICountryDataSourcesSupplier, CountryDataSourceSupplier>();
            serviceCollection.AddTransient<CountryEntityMapper>();
            serviceCollection.AddTransient<ICountryRepository, CountryRepository>();
        }

        private void AddBusinessServices()
        {
            serviceCollection.AddTransient<GetCountries>();
        }

        private void AddUiServices()
        {
            serviceCollection.AddTransient<IUiThread, UiThread>();
            serviceCollection.AddTransient<CountryModelMapper>();
            serviceCollection.AddTransient<ICountryListPresenter, CountryListPresenter>();
        }

        public static Injector GetInstance()
        {
            return instance ?? (instance = new Injector());
        }

        public void Inject<T>(out T t)
        {
            t = serviceProvider.GetService<T>();
        }
    }
}