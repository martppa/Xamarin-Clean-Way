using System;

namespace xCleanWay.Data.Repositories.DataStores.Factory
{
    public class SimpleDataStoreSupplier : ISimpleSettingsDataStoreFactory
    {
        private readonly ISettingsDataStore diskSettingsDataStore;

        public SimpleDataStoreSupplier(ISettingsDataStore diskSettingsDataStore)
        {
            this.diskSettingsDataStore = diskSettingsDataStore;
        }
        
        public ISettingsDataStore GetSettingsDataStore(SettingsDataStoreFrom dataSourceFrom)
        {
            switch (dataSourceFrom)
            {
                case SettingsDataStoreFrom.LOCAL:
                    return diskSettingsDataStore;
                
                default:
                    throw new ArgumentException("Unkown settings data source");
            }
        }
    }
}