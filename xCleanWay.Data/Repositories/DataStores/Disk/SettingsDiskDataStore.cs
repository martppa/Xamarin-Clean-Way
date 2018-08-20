using System;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataStores.Disk
{
    public class SettingsDiskDataStore : ISettingsDataStore
    {
        public IObservable<SettingsEntity> GetSettings()
        {
            throw new NotImplementedException();
        }

        public IObservable<object> SetCacheLifeTimeInMillis()
        {
            throw new NotImplementedException();
        }
    }
}