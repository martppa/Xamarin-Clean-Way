using System;
using xCleanWay.Core.Utils;

namespace xCleanWay.Data.Repositories.DataStores
{
    public interface ISettingsDataStore
    {
        IObservable<int> GetCacheLifeTimeInMillis();
        IObservable<object> SetCacheLifeTimeInMillis();
    }
}