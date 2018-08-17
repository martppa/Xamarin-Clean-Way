using System;
using xCleanWay.Data.Entities;

namespace xCleanWay.Persistence.Disk.Serialization.Binary
{
    public class SettingsBinarySerializationProvider : ISettingsProvider
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