using System;
using xCleanWay.Data.Repositories.DataStores;

namespace xCleanWay.Persistence.DataStores
{
    public class SettingsDiskDataStore : ISettingsDataStore
    {
        public IObservable<int> GetCacheLifeTimeInMillis()
        {
            throw new NotImplementedException();
        }

        public IObservable<object> SetCacheLifeTimeInMillis()
        {
            throw new NotImplementedException();
        }
    }
}