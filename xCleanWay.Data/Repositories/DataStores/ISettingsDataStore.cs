using System;
using xCleanWay.Core.Utils;

namespace xCleanWay.Data.Repositories.DataStores
{
    public interface ISettingsDataStore
    {
        IObservable<None> SetCacheLifeTimeInMillis();
    }
}