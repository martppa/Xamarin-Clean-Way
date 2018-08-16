using System;

namespace xCleanWay.Data.Repositories.DataStores.Factory
{
    public class SimpleDataStoreFactory : ISimpleSettingsDataStoreFactory
    {
        private readonly ISettingsDataStore diskSettingsDataStore;

        public SimpleDataStoreFactory(ISettingsDataStore diskSettingsDataStore)
        {
            this.diskSettingsDataStore = diskSettingsDataStore;
        }
        
        public ISettingsDataStore Build(DataStoreFrom dataSourceFrom)
        {
            switch (dataSourceFrom)
            {
                default:
                case DataStoreFrom.DISK:
                    return diskSettingsDataStore;
            }
        }
    }
}