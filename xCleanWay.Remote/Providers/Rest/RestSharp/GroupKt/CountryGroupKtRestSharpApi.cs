using System;
using System.Collections.ObjectModel;
using RestSharp;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Providers.Rest.RestSharp.GroupKt
{
    public class CountryGroupKtRestSharpApi : CountryRestSharpApi
    {
        private readonly string BASE_URL = "http://services.groupkt.com/";
        private readonly string COUNTRY_ROUTE = "country/get/all";
        
        protected override string GetBaseUrl()
        {
            return BASE_URL;
        }

        protected override string GetCountryRoute()
        {
            return COUNTRY_ROUTE;
        }

        protected override IResponseAdapter<Collection<RawCountry>> requestCountries()
        {
            IRestRequest restRequest = new RestRequest(COUNTRY_ROUTE);
            try
            {
                var restResponse = restClient.Execute<GroupKtRestResponse<Collection<RawCountry>>>(restRequest);
                return new GroupKtResponseAdapter<Collection<RawCountry>>(restResponse.Data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        protected override IResponseAdapter<RawCountry> requestCountryByIso(string iso)
        {
            throw new System.NotImplementedException();
        }
    }
}