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
using System.IO;
using System.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Country
{
    /// <summary>
    ///     This class is intended to provide countries via REST api
    ///     used a direct implementation of <see cref="IRestFramework"/>
    ///     This must be subclassed by host-oriented class.
    /// </summary>
    /// <typeparam name="Entity">
    ///     The type of country objects the API returns when
    ///     requested
    /// </typeparam>
    public abstract class CountryRestApi<Entity> : ICountryRestApi where Entity : ICountryEntity
    {
        protected readonly IRestFramework restFramework;
        
        protected CountryRestApi(IRestFramework restFramework)
        {
            this.restFramework = restFramework;
        }
        
        public List<ICountryEntity> GetCountries()
        {
            var responseAdapter = RequestCountries();
            AssertRequestWasSuccessful(responseAdapter);
            return responseAdapter.GetContent()
                .Select(item => (ICountryEntity) item).ToList();
        }

        public ICountryEntity GetCountryByISOCode(string isoCode)
        {
            var responseAdapter = RequestCountryByISOCode(isoCode);
            AssertRequestWasSuccessful(responseAdapter);
            return responseAdapter.GetContent();
        }

        protected abstract IResponseAdapter<List<Entity>> RequestCountries();
        protected abstract IResponseAdapter<Entity> RequestCountryByISOCode(string iso);

        private void AssertRequestWasSuccessful<T>(IResponseAdapter<T> responseAdapter)
        {
            if (responseAdapter.GetStatus() != ResponseStatus.OK)
                throw new IOException(responseAdapter.GetErrorMessage());
        }
        
        protected Dictionary<string, string> NoParameters()
        {
            return new Dictionary<string, string>();
        }
    }
}