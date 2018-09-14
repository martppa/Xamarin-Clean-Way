using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.DataStores.Providers;
using xCleanWay.Data.Repositories.Providers.RawModels;
using xCleanWay.Data.Repositories.Providers.RawModels.Mappers;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;

namespace xCleanWay.Data.Repositories.Providers.Settings
{
    public class SettingsDiskProvider : ISettingsProvider
    {
        private readonly RawSettingsMapper rawSettingsMapper;
        private readonly ISettingsSerializer settingsSerializer;

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