using Microsoft.Extensions.DependencyInjection;
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
using xCleanWay.Data.Repositories.Providers;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Rest;
using xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt;
using xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries;
using xCleanWay.Data.Repositories.Providers.Settings;
using xCleanWay.Data.Threading;
using xCleanWay.Ui.Models.Mapper;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Presenters.Country;
using xCleanWay.Ui.Threading;

namespace xCleanWay.Di
{
    public abstract class BusinessInjector
    {
        
        protected ServiceCollection serviceCollection;
        private ServiceProvider serviceProvider;
        
        protected BusinessInjector()
        {
            InitializeInjector();
        }

        private void InitializeInjector()
        {
            serviceCollection = new ServiceCollection();
            AddDataServices();
            AddCoreServices();
            AddUiServices();
            AddExtraServices();
            serviceProvider = serviceCollection.BuildServiceProvider();
        }
        
        private void AddDataServices()
        {
            serviceCollection.AddTransient<RawCountryMapper>();
            serviceCollection.AddTransient<ICountryRestApi, GroupKtCountryRestApi>();
            serviceCollection.AddTransient<ICountryProvider, CountryRestProvider>();
            serviceCollection.AddTransient<RawSettingsMapper>();
            serviceCollection.AddTransient<ISettingsProvider, SettingsDiskProvider>();
            serviceCollection.AddTransient<IDataThread, DataThread>();
            serviceCollection.AddTransient<ICountryDataSource, CountryNetworkDataSource>();
            serviceCollection.AddTransient<ICountryDataSourceSimpleFactory, CountryDataSourceSimpleFactory>();
            serviceCollection.AddTransient<CountryEntityMapper>();
            serviceCollection.AddTransient<ICountryRepository, CountryRepository>();
        }

        private void AddCoreServices()
        {
            serviceCollection.AddTransient<GetCountries>();
        }

        private void AddUiServices()
        {
            serviceCollection.AddTransient<IUiThread, UiThread>();
            serviceCollection.AddTransient<CountryModelMapper>();
            serviceCollection.AddTransient<ICountryListPresenter, CountryListPresenter>();
        }

        protected abstract void AddExtraServices();

        public void Inject<T>(out T t)
        {
            t = serviceProvider.GetService<T>();
        }
    }
}