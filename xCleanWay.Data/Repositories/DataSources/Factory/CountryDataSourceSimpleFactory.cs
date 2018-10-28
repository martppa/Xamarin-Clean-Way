using xCleanWay.Data.Repositories.DataSources.Cache;
using xCleanWay.Data.Repositories.DataSources.Network;

namespace xCleanWay.Data.Repositories.DataSources.Factory
{
    /// <summary>
    /// This simple factory decide which source provide depending
    /// on the cache (cache is still to be added)
    /// </summary>
    public class CountryDataSourceSimpleFactory : ICountryDataSourceSimpleFactory
    {
        private readonly CountryNetworkDataSource countryNetworkDataSource;
        private readonly CountryCacheDataSource countryCacheDataSource;

        public CountryDataSourceSimpleFactory(CountryNetworkDataSource countryNetworkDataSource, 
            CountryCacheDataSource countryCacheDataSource)
        {
            this.countryNetworkDataSource = countryNetworkDataSource;
            this.countryCacheDataSource = countryCacheDataSource;
        }

        public ICountryDataSource Build()
        {
            if (!countryCacheDataSource.HasExpired)
                return countryCacheDataSource;
            return countryNetworkDataSource;
        }
    }
}