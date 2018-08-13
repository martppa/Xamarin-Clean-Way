using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using xCleanWay.Core.Models;
using xCleanWay.Core.Repositories;
using xCleanWay.Data.Entities.Mappers;
using xCleanWay.Data.Repositories.DataSource;
using xCleanWay.Data.Repositories.DataSource.Factory;

namespace xCleanWay.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ISimpleCountryDataSourceFactory simpleCountryDataSourceFactory;
        private readonly CountryEntityMapper countryEntityMapper;
        
        public CountryRepository(ISimpleCountryDataSourceFactory simpleCountryDataSourceFactory, 
            CountryEntityMapper countryEntityMapper)
        {
            this.simpleCountryDataSourceFactory = simpleCountryDataSourceFactory;
            this.countryEntityMapper = countryEntityMapper;
        }

        public IObservable<Collection<Country>> GetCountries()
        {
            var countryDataSource = simpleCountryDataSourceFactory.Build(SourceType.NETWORK);
            return countryDataSource.GetCountries()
                .Select(country => countryEntityMapper.transform(country));
        }

        public IObservable<Country> getCountryByISOCode(string isoCode)
        {
            var countryDataSource = simpleCountryDataSourceFactory.Build(SourceType.NETWORK);
            return countryDataSource.getCountryByISOCode(isoCode)
                .Select(country => countryEntityMapper.transform(country));
        }
    }
}