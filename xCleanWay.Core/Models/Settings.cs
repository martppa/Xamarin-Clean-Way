namespace xCleanWay.Core.Models
{
    /// <summary>
    /// Settings model in the Core data layer
    /// </summary>
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