using System;

namespace xCleanWay.Persistence.RawModels
{
    [Serializable]
    public class RawSettings
    {
        private static int DEFAULT_CACHE_LIFETIME_IN_MILLIS = 60000;
        
        private int countryCacheInMillis;
        
        private RawSettings()
        {
            countryCacheInMillis = DEFAULT_CACHE_LIFETIME_IN_MILLIS;
        }

        public static RawSettings Default()
        {
            return new RawSettings();
        }
        
        public RawSettings(int countryCacheInMillis)
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