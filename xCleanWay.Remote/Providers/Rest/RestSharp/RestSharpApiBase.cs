using RestSharp;

namespace xCleanWay.Remote.Net.Rest.RestSharp
{
    public abstract class RestSharpApiBase
    {
        protected RestClient restClient;

        public RestSharpApiBase()
        {
            restClient = new RestClient(GetBaseUrl());
        }

        protected abstract string GetBaseUrl();
        protected abstract string GetCountryRoute();
    }
}