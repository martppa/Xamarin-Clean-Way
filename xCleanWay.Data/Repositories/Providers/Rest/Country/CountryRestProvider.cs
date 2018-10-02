using System.Collections.Generic;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest.Country
{
    public class CountryRestProvider : ICountryProvider
    {
        private readonly ICountryRestApi countryRestApi;

        public CountryRestProvider(ICountryRestApi countryRestApi)
        {
            this.countryRestApi = countryRestApi;
        }
        
        public List<ICountryEntity> GetCountries()
        {
            return countryRestApi.GetCountries();
        }

        public ICountryEntity GetCountryByISOCode(string isoCode)
        {
            return countryRestApi.GetCountryByISOCode(isoCode);
        }
    }
}