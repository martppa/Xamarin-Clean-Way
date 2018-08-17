using System;
using xCleanWay.Data.Entities;

namespace xCleanWay.Persistence.Disk
{
    public interface ISettingsProvider
    {
        IObservable<SettingsEntity> GetSettings();

        IObservable<object> SetCacheLifeTimeInMillis();
    }
}