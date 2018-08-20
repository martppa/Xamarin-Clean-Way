namespace xCleanWay.Core.Models
{
    public class Settings
    {
        private long countryCacheInMillis;
        
        public Settings(long countryCacheInMillis)
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