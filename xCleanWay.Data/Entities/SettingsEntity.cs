namespace xCleanWay.Data.Entities
{
    public class SettingsEntity
    {
        private long countryCacheInMillis;
        
        public SettingsEntity(long countryCacheInMillis)
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