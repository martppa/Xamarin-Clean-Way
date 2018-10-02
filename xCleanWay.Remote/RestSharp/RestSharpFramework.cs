using System.Collections.Generic;
using RestSharp;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;

namespace xCleanWay.Remote.RestSharp
{
    /// <summary>
    ///     Platform specific implementation of <see cref="IRestFramework"/>
    ///     which uses RestSharp as REST client
    /// </summary>
    public class RestSharpFramework : IRestFramework
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