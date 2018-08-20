using System;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;
using xCleanWay.Remote.Net;
using xCleanWay.Remote.Net.Rest;
using xCleanWay.Remote.RawModels.Mappers;

namespace xCleanWay.Remote.Providers.Rest
{
    public class CountryRestProvider : ICountryProvider
    {
        private readonly ICountryRestApi countryRestApi;
        private readonly RawCountryMapper rawCountryMapper;

        public CountryRestProvider(ICountryRestApi countryRestApi)
        {
            this.countryRestApi = countryRestApi;
        }
        
        public Collection<CountryEntity> GetCountries()
        {
            return rawCountryMapper.Transform(countryRestApi.GetCountries());
        }

        public CountryEntity GetCountryByISOCode(string isoCode)
        {
            return rawCountryMapper.Transform(countryRestApi.GetCountryByISOCode(isoCode));
        }
    }
}