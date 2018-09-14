using xCleanWay.Data.Repositories.DataSources.Suppliers;

namespace xCleanWay.Data.Repositories.DataSources.Factory
{
    public class CountryDataSourceSimpleFactory : ICountryDataSourceSimpleFactory
    {
        private readonly ICountryDataSource countryRemoteDataSource;

        public CountryDataSourceSimpleFactory(ICountryDataSource countryDataSource)
        {
            this.countryRemoteDataSource = countryDataSource;
        }

        public ICountryDataSource Build()
        {
            return countryRemoteDataSource;
        }
    }
}