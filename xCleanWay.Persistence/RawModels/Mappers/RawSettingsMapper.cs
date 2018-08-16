using xCleanWay.Data.Entities;

namespace xCleanWay.Persistence.RawModels.Mappers
{
    public class RawSettingsMapper
    {
        public SettingsEntity transform(RawSettings rawSettings)
        {
            return new SettingsEntity(rawSettings.CountryCacheInMillis);
        }
    }
}