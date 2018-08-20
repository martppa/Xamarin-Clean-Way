using System;
using System.Collections.ObjectModel;
using System.IO;
using RestSharp;
using xCleanWay.Remote.Net.Rest;
using xCleanWay.Remote.Net.Rest.RestSharp;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Providers.Rest.RestSharp
{
    public abstract class CountryRestSharpApi : RestSharpApiBase, ICountryRestApi
    {
        public Collection<RawCountry> GetCountries()
        {
            var responseAdapter = requestCountries();
            AssertRequestWasSuccessful(responseAdapter);
            return responseAdapter.GetContent();
        }

        public RawCountry GetCountryByISOCode(string isoCode)
        {
            var responseAdapter = requestCountryByIso(isoCode);
            AssertRequestWasSuccessful(responseAdapter);
            return responseAdapter.GetContent();
        }

        protected abstract IResponseAdapter<Collection<RawCountry>> requestCountries();
        protected abstract IResponseAdapter<RawCountry> requestCountryByIso(string iso);

        private void AssertRequestWasSuccessful<T>(IResponseAdapter<T> responseAdapter)
        {
            if (responseAdapter.GetStatus() != ResponseStatus.OK)
                throw new IOException(responseAdapter.GetErrorMessage());
        }
    }
}