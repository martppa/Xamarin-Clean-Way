using xCleanWay.Data.Repositories.Providers.RawModels;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;

namespace xCleanWay.AndroidData.Persistence.Preferences
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