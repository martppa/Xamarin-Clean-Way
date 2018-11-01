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
using Microsoft.Extensions.Caching.Memory;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Cache;

namespace xCleanWay.iOSData.Persistence.Cache.Country
{
    public class CountryCustomCache : ICountryCache
    {
        private const string COUNTRY_LIST_ID = "COUNTRY_LIST_ID";
        private const long LIFE_TIME = 3600000L;
        
        private readonly MemoryCache objectCache;

        public CountryCustomCache()
        {
            objectCache =  new MemoryCache(new MemoryCacheOptions());
        }
        
        public bool HasExpired()
        {
            return !objectCache.TryGetValue(COUNTRY_LIST_ID, out _);
        }

        public void save(List<ICountryEntity> countryEntityList)
        {
            objectCache.Set(COUNTRY_LIST_ID, countryEntityList,
                DateTimeOffset.FromUnixTimeMilliseconds(LIFE_TIME));
        }

        public List<ICountryEntity> get()
        {
            return objectCache.Get(COUNTRY_LIST_ID) as List<ICountryEntity>;
        }
    }
}