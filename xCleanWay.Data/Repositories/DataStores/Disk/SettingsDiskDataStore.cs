using System;
using xCleanWay.Core.Utils;

namespace xCleanWay.Data.Repositories.DataStores.Disk
{
    /// <summary>
    /// Intended to store settings parameters
    /// </summary>
    public class SettingsDiskDataStore : ISettingsDataStore
    {
        public IObservable<None> SetCacheLifeTimeInMillis()
        {
            throw new NotImplementedException();
        }
    }
}