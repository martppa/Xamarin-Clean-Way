using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.DataSources;
using xCleanWay.Remote.Net;
using xCleanWay.Remote.RawModels.Mappers;

namespace xCleanWay.Remote.DataSources
{
    public class CountryNetworkDataSource : ICountryDataSource
    {
        private readonly ICountryProvider countryProvider;
        private readonly RawCountryMapper rawCountryMapper;
        
        public CountryNetworkDataSource(RawCountryMapper rawCountryMapper)
        {
            countryProvider = CountryProviderFactory
                .Create(NetworkAPI.REST).Build();
            this.rawCountryMapper = rawCountryMapper;
        }
        
        public IObservable<Collection<CountryEntity>> GetCountries()
        {
            return countryProvider.GetCountries().Select(rawCountry => rawCountryMapper.Transform(rawCountry));
        }

        public IObservable<CountryEntity> getCountryByISOCode(string isoCode)
        {
            return countryProvider.getCountryByISOCode(isoCode).Select(rawCountry => rawCountryMapper.Transform(rawCountry));
        }
    }
}