using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Persistence.RawModels.Mappers
{
    public class RawSettingsMapper
    {
        public SettingsEntity transform(RawSettings rawSettings)
        {
            return new SettingsEntity(rawSettings.CountryCacheInMillis);
        }

        public Collection<SettingsEntity> transform(Collection<RawSettings> rawSettingses)
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