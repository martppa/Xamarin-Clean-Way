using System;
using System.Collections.ObjectModel;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net.Rest.RestSharp
{
    public class CountryRestSharpApi : RestSharpApiBase, ICountryRestApi
    {
        public IObservable<Collection<RawCountry>> GetCountries()
        {
            throw new NotImplementedException();
        }

        public IObservable<RawCountry> GetCountryByISOCode(string isoCode)
        {
            throw new NotImplementedException();
        }
    }
}