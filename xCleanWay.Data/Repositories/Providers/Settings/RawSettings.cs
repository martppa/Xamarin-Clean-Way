using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Settings
{
    public class RawSettings : ISettingsEntity
    {
        private long countryCacheInMillis;
        
        public RawSettings(long countryCacheInMillis)
        {
            this.countryCacheInMillis = countryCacheInMillis;
        }

        public long CountryCacheInMillis
        {
            get => countryCacheInMillis;
            set => countryCacheInMillis = value;
        }
    }
}