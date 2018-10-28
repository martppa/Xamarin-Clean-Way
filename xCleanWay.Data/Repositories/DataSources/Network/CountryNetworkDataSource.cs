using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Cache;
using xCleanWay.Data.Repositories.Providers;

namespace xCleanWay.Data.Repositories.DataSources.Network
{
    /// <summary>
    /// Country data source to retrieve countries from the network
    /// by using a specific country provider
    /// </summary>
    public class CountryNetworkDataSource : ICountryDataSource
    {
        private readonly ICountryProvider countryProvider;
        private readonly ICountryCache countryCache;
        
        public CountryNetworkDataSource(ICountryProvider countryProvider, ICountryCache countryCache)
        {
            this.countryProvider = countryProvider;
            this.countryCache = countryCache;
        }
        
        public IObservable<List<ICountryEntity>> GetCountries()
        {
            return Observable.Create<List<ICountryEntity>>(emitter =>
            {
                var countryEntities = countryProvider.GetCountries();
                emitter.OnNext(countryEntities);
                emitter.OnCompleted();
                return () => { };

            }).Do(countryList =>
            {
                countryCache.save(countryList);
            });
        }

        public IObservable<ICountryEntity> getCountryByISOCode(string isoCode)
        {
            return Observable.Create<ICountryEntity>(emitter =>
            {
                var countryEntity = countryProvider.GetCountryByISOCode(isoCode);
                emitter.OnNext(countryEntity);
                emitter.OnCompleted();
                return () => { };
            });
        }
    }
}