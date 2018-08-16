using System;
using System.Collections.ObjectModel;
using xCleanWay.Remote.Net.Rest.RestSharp;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net.Rest
{
    public class RestCountryProvider : ICountryProvider
    {
        private readonly IRestCountryApi restCountryApi;

        public RestCountryProvider()
        {
            restCountryApi = new RestSharpCountryApi();
        }
        
        public IObservable<Collection<RawCountry>> GetCountries()
        {
            return restCountryApi.GetCountries();
        }

        public IObservable<RawCountry> getCountryByISOCode(string isoCode)
        {
            return restCountryApi.getCountryByISOCode(isoCode);
        }
    }
}