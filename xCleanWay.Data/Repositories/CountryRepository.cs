using System;
using System.Reactive.Linq;
using xCleanWay.Core.Models;
using xCleanWay.Core.Repositories;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities.Mappers;
using xCleanWay.Data.Repositories.DataSources;
using xCleanWay.Data.Repositories.DataSources.Suppliers;

namespace xCleanWay.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ICountryDataSourceSimpleFactory _countryDataSourceSimpleFactory;
        private readonly CountryEntityMapper countryEntityMapper;
        
        public CountryRepository(ICountryDataSourceSimpleFactory countryDataSourceSimpleFactory, 
            CountryEntityMapper countryEntityMapper)
        {
            this._countryDataSourceSimpleFactory = countryDataSourceSimpleFactory;
            this.countryEntityMapper = countryEntityMapper;
        }

        public IObservable<Collection<Country>> GetCountries()
        {
            //TODO: Check in cache first
            var countryDataSource = _countryDataSourceSimpleFactory.Build();
            return countryDataSource.GetCountries()
                .Select(country => countryEntityMapper.transform(country));
        }

        public IObservable<Country> getCountryByISOCode(string isoCode)
        {
            //TODO: Check in cache first
            var countryDataSource = _countryDataSourceSimpleFactory.Build();
            return countryDataSource.getCountryByISOCode(isoCode)
                .Select(country => countryEntityMapper.transform(country));
        }
    }
}