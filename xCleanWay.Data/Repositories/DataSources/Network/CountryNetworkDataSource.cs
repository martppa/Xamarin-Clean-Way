using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers.Country;

namespace xCleanWay.Data.Repositories.DataSources.Network
{
    public class CountryNetworkDataSource : ICountryDataSource
    {
        private readonly ICountryProvider countryProvider;
        
        public CountryNetworkDataSource(ICountryProvider countryProvider)
        {
            this.countryProvider = countryProvider;
        }
        
        public IObservable<Collection<CountryEntity>> GetCountries()
        {
            return Observable.Create<Collection<CountryEntity>>(emitter =>
            {
                Collection<CountryEntity> countryEntities = countryProvider.GetCountries();
                emitter.OnNext(countryEntities);
                emitter.OnCompleted();
                return () => { };
                
            });
        }

        public IObservable<CountryEntity> getCountryByISOCode(string isoCode)
        {
            return Observable.Create<CountryEntity>(emitter =>
            {
                CountryEntity countryEntity = countryProvider.GetCountryByISOCode(isoCode);
                emitter.OnNext(countryEntity);
                emitter.OnCompleted();
                return () => { };
            });
        }
    }
}