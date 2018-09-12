using System;

namespace xCleanWay.Data.Repositories.DataSources.Suppliers
{
    public class CountryDataSourceSupplier : ICountryDataSourcesSupplier
    {
        private ICountryDataSource countryRemoteDataSource;

        public CountryDataSourceSupplier(ICountryDataSource countryDataSource)
        {
            this.countryRemoteDataSource = countryDataSource;
        }

        public ICountryDataSource GetCountryDataSource(CountryDataSourceFrom countryDataSourceFrom)
        {
            switch (countryDataSourceFrom)
            {
                case CountryDataSourceFrom.REMOTE:
                    return countryRemoteDataSource;
                
                default:
                    throw new ArgumentException("Unknown data source origin");
            }
        }
    }
}