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