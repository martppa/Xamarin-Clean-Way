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

using xCleanWay.Data.Repositories.DataSources.Cache;
using xCleanWay.Data.Repositories.DataSources.Network;

namespace xCleanWay.Data.Repositories.DataSources.Factory
{
    /// <summary>
    /// This simple factory decide which source provide depending
    /// on the cache (cache is still to be added)
    /// </summary>
    public class CountryDataSourceSimpleFactory : ICountryDataSourceSimpleFactory
    {
        private readonly CountryNetworkDataSource countryNetworkDataSource;
        private readonly CountryCacheDataSource countryCacheDataSource;

        public CountryDataSourceSimpleFactory(CountryNetworkDataSource countryNetworkDataSource, 
            CountryCacheDataSource countryCacheDataSource)
        {
            this.countryNetworkDataSource = countryNetworkDataSource;
            this.countryCacheDataSource = countryCacheDataSource;
        }

        public ICountryDataSource Build()
        {
            if (!countryCacheDataSource.HasExpired)
                return countryCacheDataSource;
            return countryNetworkDataSource;
        }
    }
}