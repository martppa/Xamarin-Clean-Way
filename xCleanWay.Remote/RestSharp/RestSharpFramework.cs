/*
 * Copyright 2018 Humberto Martín Dieppa, Open source project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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