using System;
using System.Collections.ObjectModel;
using xCleanWay.Remote.Net.Rest.RestSharp;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net.Rest
{
    public class CountryRestProvider : ICountryProvider
    {
        private readonly ICountryRestApi _countryRestApi;

        public CountryRestProvider()
        {
            _countryRestApi = new CountryRestSharpApi();
        }
        
        public IObservable<Collection<RawCountry>> GetCountries()
        {
            return _countryRestApi.GetCountries();
        }

        public IObservable<RawCountry> getCountryByISOCode(string isoCode)
        {
            return _countryRestApi.GetCountryByISOCode(isoCode);
        }
    }
}