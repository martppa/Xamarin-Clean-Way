using System.Collections.Generic;
using RestSharp;
using xCleanWay.Remote.Providers.Rest;
using xCleanWay.Remote.Providers.Rest.Country;

namespace xCleanWay.GtkData.Remote.RestSharp.Country
{
    public class RestSharpSharpFramework : IRestFramework
    {
        public T ExecuteGet<T>(string baseUrl, string route, Dictionary<string, string> parameters) where T : new()
        {
            var restClient = new RestClient(baseUrl);
            var restRequest = BuildRequest(route, parameters);
            var response = restClient.Execute<T>(restRequest);
            return response.Data;
        }
        
        private IRestRequest BuildRequest(string route, Dictionary<string, string> parameters)
        {
            IRestRequest restRequest = new RestRequest(route);
            foreach (var parameter in parameters)
            {
                restRequest.AddParameter(parameter.Key, parameter.Value);
            }

            return restRequest;
        }
    }
}