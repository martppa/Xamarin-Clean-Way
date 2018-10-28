using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Cache;

namespace xCleanWay.Data.Repositories.DataSources.Cache
{
    public class CountryCacheDataSource : ICountryDataSource
    {
        private readonly ICountryCache cache;

        public CountryCacheDataSource(ICountryCache cache)
        {
            this.cache = cache;
        }

        public IObservable<List<ICountryEntity>>GetCountries()
        {
            return Observable.Create<List<ICountryEntity>>(emitter =>
            {
                var countries = cache.get();
                emitter.OnNext(countries);
                emitter.OnCompleted();
                return () => { };
            });
        }

        public bool HasExpired => cache.HasExpired();

        public IObservable<ICountryEntity> getCountryByISOCode(string isoCode)
        {
            throw new NotImplementedException();
        }
    }
}