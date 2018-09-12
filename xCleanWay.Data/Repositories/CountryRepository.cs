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
        private readonly ICountryDataSourcesSupplier countryDataSourcesSupplier;
        private readonly CountryEntityMapper countryEntityMapper;
        
        public CountryRepository(ICountryDataSourcesSupplier countryDataSourcesSupplier, 
            CountryEntityMapper countryEntityMapper)
        {
            this.countryDataSourcesSupplier = countryDataSourcesSupplier;
            this.countryEntityMapper = countryEntityMapper;
        }

        public IObservable<Collection<Country>> GetCountries()
        {
            //TODO: Check in cache first
            var countryDataSource = countryDataSourcesSupplier.GetCountryDataSource(CountryDataSourceFrom.REMOTE);
            return countryDataSource.GetCountries()
                .Select(country => countryEntityMapper.transform(country));
        }

        public IObservable<Country> getCountryByISOCode(string isoCode)
        {
            //TODO: Check in cache first
            var countryDataSource = countryDataSourcesSupplier.GetCountryDataSource(CountryDataSourceFrom.REMOTE);
            return countryDataSource.getCountryByISOCode(isoCode)
                .Select(country => countryEntityMapper.transform(country));
        }
    }
}