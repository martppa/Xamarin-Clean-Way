using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.DataStores.Providers;
using xCleanWay.Persistence.Disk.Serialization;
using xCleanWay.Persistence.RawModels;
using xCleanWay.Persistence.RawModels.Mappers;

namespace xCleanWay.Persistence.Providers
{
    public class SettingsDiskProvider : ISettingsProvider
    {
        private RawSettingsMapper rawSettingsMapper;
        private ISettingsSerializer settingsSerializer;

        public SettingsDiskProvider(ISettingsSerializer settingsSerializer, RawSettingsMapper rawSettingsMapper)
        {
            this.rawSettingsMapper = rawSettingsMapper;
            this.settingsSerializer = settingsSerializer;
        }
        
        public SettingsEntity GetSettings()
        {
            return rawSettingsMapper.Transform(settingsSerializer.GetSettings());
        }

        public void SetCacheLifeTimeInMillis(long timeInMillis)
        {
            RawSettings rawSettings = settingsSerializer.GetSettings();
            rawSettings.CountryCacheInMillis = timeInMillis;
            settingsSerializer.WriteSettings(rawSettings);
        }
    }
}