using System;
using System.Collections.ObjectModel;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net.Rest.RestSharp
{
    public class RestSharpCountryApi : RestSharpApiBase, IRestCountryApi
    {
        public IObservable<Collection<RawCountry>> GetCountries()
        {
            throw new NotImplementedException();
        }

        public IObservable<RawCountry> getCountryByISOCode(string isoCode)
        {
            throw new NotImplementedException();
        }
    }
}