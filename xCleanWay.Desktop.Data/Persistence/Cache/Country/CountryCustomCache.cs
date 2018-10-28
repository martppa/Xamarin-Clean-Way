using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Cache;

namespace xCleanWay.Desktop.Data.Persistence.Cache.Country
{
    public class CountryCustomCache : ICountryCache
    {
        private const string CACHE_ID = "CACHE_ID";
        private const string COUNTRY_LIST_ID = "COUNTRY_LIST_ID";
        private const long LIFE_TIME = 3600000L;
        
        private ObjectCache objectCache;

        public CountryCustomCache()
        {
            objectCache =  new MemoryCache(CACHE_ID);
        }
        
        public bool HasExpired()
        {
            return !objectCache.Contains(COUNTRY_LIST_ID);
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