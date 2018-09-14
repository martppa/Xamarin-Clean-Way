using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.RawModels.Mappers
{
    public class RawSettingsMapper
    {
        public SettingsEntity Transform(RawSettings rawSettings)
        {
            return new SettingsEntity(rawSettings.CountryCacheInMillis);
        }

        public Collection<SettingsEntity> Transform(Collection<RawSettings> rawSettingses)
        {
            var settingsEntities = new Collection<SettingsEntity>();
            foreach (var rawSettings in rawSettingses)
            {
                settingsEntities.Add(new SettingsEntity(rawSettings.CountryCacheInMillis));
            }

            return settingsEntities;
        }
    }
}