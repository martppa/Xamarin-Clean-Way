using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;

namespace xCleanWay.Data.Repositories.Providers.Settings
{
    public class SettingsDiskProvider : ISettingsProvider
    {
        private readonly ISettingsEntity rawSettingsMapper;
        private readonly ISettingsSerializer settingsSerializer;

        public SettingsDiskProvider(ISettingsSerializer settingsSerializer)
        {
            this.settingsSerializer = settingsSerializer;
        }
        
        public ISettingsEntity GetSettings()
        {
            return settingsSerializer.GetSettings();
        }

        public void SetCacheLifeTimeInMillis(long timeInMillis)
        {
            var rawSettings = settingsSerializer.GetSettings();
            rawSettings.CountryCacheInMillis = timeInMillis;
            settingsSerializer.WriteSettings(rawSettings);
        }
    }
}