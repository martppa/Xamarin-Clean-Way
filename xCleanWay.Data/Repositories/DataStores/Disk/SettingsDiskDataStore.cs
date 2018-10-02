using System;
using xCleanWay.Core.Utils;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataStores.Disk
{
    public class SettingsDiskDataStore : ISettingsDataStore
    {
        public IObservable<ISettingsEntity> GetSettings()
        {
            throw new NotImplementedException();
        }

        public IObservable<None> SetCacheLifeTimeInMillis()
        {
            throw new NotImplementedException();
        }
    }
}