using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Data.Entities.Mappers
{
    public class SettingsEntityMapper
    {
        public Settings Transform(ISettingsEntity settingsEntity)
        {
            return new Settings(settingsEntity.CountryCacheInMillis);
        }

        public Collection<Settings> Transform(Collection<ISettingsEntity> settingsEntities)
        {
            var settingses = new Collection<Settings>();
            foreach (var settingsEntity in settingsEntities)
            {
                settingses.Add(Transform(settingsEntity));
            }

            return settingses;
        }
    }
}