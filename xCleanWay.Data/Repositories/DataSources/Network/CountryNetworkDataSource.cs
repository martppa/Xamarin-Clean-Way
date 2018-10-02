using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers;

namespace xCleanWay.Data.Repositories.DataSources.Network
{
    public class CountryNetworkDataSource : ICountryDataSource
    {
        private readonly ICountryProvider countryProvider;
        
        public CountryNetworkDataSource(ICountryProvider countryProvider)
        {
            this.countryProvider = countryProvider;
        }
        
        public IObservable<Collection<ICountryEntity>> GetCountries()
        {
            return Observable.Create<Collection<ICountryEntity>>(emitter =>
            {
                Collection<ICountryEntity> countryEntities = countryProvider.GetCountries();
                emitter.OnNext(countryEntities);
                emitter.OnCompleted();
                return () => { };
                
            });
        }

        public IObservable<ICountryEntity> getCountryByISOCode(string isoCode)
        {
            return Observable.Create<ICountryEntity>(emitter =>
            {
                ICountryEntity countryEntity = countryProvider.GetCountryByISOCode(isoCode);
                emitter.OnNext(countryEntity);
                emitter.OnCompleted();
                return () => { };
            });
        }
    }
}