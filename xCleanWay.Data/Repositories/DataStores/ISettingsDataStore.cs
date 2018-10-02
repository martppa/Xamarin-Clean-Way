using System;
using xCleanWay.Core.Utils;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataStores
{
    public interface ISettingsDataStore
    {
        IObservable<None> SetCacheLifeTimeInMillis();
    }
}