using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Data.Entities.Mappers
{
    /// <summary>
    /// This class transforms <see cref="ISettingsEntity"/> in data layer into
    /// <see cref="Settings"/> in core layer.
    /// </summary>
    public class SettingsEntityMapper
    {
        public Settings Transform(ISettingsEntity settingsEntity)
        {
            return new Settings(settingsEntity.CountryCacheInMillis);
        }

        public Collection<Settings> Transform(Collection<ISettingsEntity> settingsEntities)
        {
            var settingsCollection = new Collection<Settings>();
            foreach (var settingsEntity in settingsEntities)
            {
                settingsCollection.Add(Transform(settingsEntity));
            }

            return settingsCollection;
        }
    }
}