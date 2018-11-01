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

using System;
using System.Collections.Generic;
using xCleanWay.Data.Repositories.Providers.Rest.Country;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries
{
    /// <summary>
    ///     This is a RestCountries host oriented class to deal with its country responses
    /// </summary>
    public class RestCountriesCountryRestApi : CountryRestApi<RestCountriesCountryModel>
    {
        private readonly string BASE_URL = "https://restcountries.eu/";
        private readonly string COUNTRY_ROUTE = "rest/v2/all";
        private readonly string ISO_CODE_KEY = "isoCode";
        
        public RestCountriesCountryRestApi(IRestFramework restFramework) 
            : base(restFramework) {}

        protected override IResponseAdapter<List<RestCountriesCountryModel>> RequestCountries()
        {
            try
            {
                var response = restFramework
                    .ExecuteGet<RestCountriesResponse>(BASE_URL,
                        COUNTRY_ROUTE, NoParameters());
                if (response == null)
                    throw new Exception("No data from server");
                return new RestCountriesResponseAdapter(response);
            }
            catch (Exception exception)
            {
                return new RestCountriesResponseAdapter(ResponseStatus.ERROR, exception.Message);
            }
        }

        protected override IResponseAdapter<RestCountriesCountryModel> RequestCountryByISOCode(string iso)
        {
            throw new System.NotImplementedException();
        }
    }
}