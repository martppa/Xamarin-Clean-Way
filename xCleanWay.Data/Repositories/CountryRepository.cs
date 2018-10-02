using System;
using System.Reactive.Linq;
using xCleanWay.Core.Models;
using xCleanWay.Core.Repositories;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities.Mappers;
using xCleanWay.Data.Repositories.DataSources;
using xCleanWay.Data.Repositories.DataSources.Factory;

namespace xCleanWay.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ICountryDataSourceSimpleFactory countryDataSourceSimpleFactory;
        private readonly CountryEntityMapper countryEntityMapper;
        
        public CountryRepository(ICountryDataSourceSimpleFactory countryDataSourceSimpleFactory, 
            CountryEntityMapper countryEntityMapper)
        {
            this.countryDataSourceSimpleFactory = countryDataSourceSimpleFactory;
            this.countryEntityMapper = countryEntityMapper;
        }

        public IObservable<Collection<Country>> GetCountries()
        {
            var countryDataSource = countryDataSourceSimpleFactory.Build();
            return countryDataSource.GetCountries()
                .Select(country => countryEntityMapper.Transform(country));
        }

        public IObservable<Country> getCountryByISOCode(string isoCode)
        {
            var countryDataSource = countryDataSourceSimpleFactory.Build();
            return countryDataSource.getCountryByISOCode(isoCode)
                .Select(country => countryEntityMapper.Transform(country));
        }
    }
}