namespace xCleanWay.Data.Repositories.DataSources.Factory
{
    /// <summary>
    /// This simple factory decide which source provide depending
    /// on the cache (cache is still to be added)
    /// </summary>
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