using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataStores.Providers
{
    public interface ISettingsProvider
    {
        ISettingsEntity GetSettings();

        void SetCacheLifeTimeInMillis(long timeInMillis);
    }
}