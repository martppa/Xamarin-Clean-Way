using Microsoft.Extensions.DependencyInjection;
using xCleanWay.AndroidData.Persistence.Preferences;
using xCleanWay.Core.Interactors.Country;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Data.Entities.Mappers;
using xCleanWay.Data.Repositories;
using xCleanWay.Data.Repositories.DataSources;
using xCleanWay.Data.Repositories.DataSources.Factory;
using xCleanWay.Data.Repositories.DataSources.Network;
using xCleanWay.Data.Repositories.DataSources.Suppliers;
using xCleanWay.Data.Repositories.DataStores.Providers;
using xCleanWay.Data.Repositories.Providers.Country;
using xCleanWay.Data.Repositories.Providers.Country.Rest.Host.RestCountries;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest;
using xCleanWay.Data.Repositories.Providers.Settings;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;
using xCleanWay.Data.Threading;
using xCleanWay.Remote.Providers.Rest.Country;
using xCleanWay.Remote.RestSharp.xCleanWay.Remote.RestSharp;
using xCleanWay.Ui.Models.Mapper;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Presenters.Country;
using xCleanWay.Ui.Threading;

namespace xCleanWay.Android.Di
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
            serviceCollection.AddTransient<ICountryDataSourceSimpleFactory, CountryDataSourceSimpleFactory>();
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