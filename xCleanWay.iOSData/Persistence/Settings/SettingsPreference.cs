using xCleanWay.Data.Repositories.Providers.Settings;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;

namespace xCleanWay.iOSData.Persistence.Settings
{
    public class SettingsPreference : ISettingsSerializer
    {
        public RawSettings GetSettings()
        {
            throw new System.NotImplementedException();
        }

        public void WriteSettings(RawSettings rawSettings)
        {
            throw new System.NotImplementedException();
        }
    }
}