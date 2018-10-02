using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest
{
    public class CountryRestProvider : ICountryProvider
    {
        private readonly ICountryRestApi countryRestApi;

        public CountryRestProvider(ICountryRestApi countryRestApi)
        {
            this.countryRestApi = countryRestApi;
        }
        
        public Collection<ICountryEntity> GetCountries()
        {
            return countryRestApi.GetCountries();
        }

        public ICountryEntity GetCountryByISOCode(string isoCode)
        {
            return countryRestApi.GetCountryByISOCode(isoCode);
        }
    }
}