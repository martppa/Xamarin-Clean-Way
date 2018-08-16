namespace xCleanWay.Data.Entities
{
    public class SettingsEntity
    {
        private int countryCacheInMillis;
        
        public SettingsEntity(int countryCacheInMillis)
        {
            this.countryCacheInMillis = countryCacheInMillis;
        }


        public int CountryCacheInMillis
        {
            get => countryCacheInMillis;
            set => countryCacheInMillis = value;
        }
    }
}