using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataStores.Providers
{
    public interface ISettingsProvider
    {
        SettingsEntity GetSettings();

        void SetCacheLifeTimeInMillis(long timeInMillis);
    }
}