namespace xCleanWay.Data.Repositories.DataStores.Factory
{
    public interface ISimpleSettingsDataStoreFactory
    {
        ISettingsDataStore GetSettingsDataStore(SettingsDataStoreFrom dataSourceFrom);
    }
    
    public enum SettingsDataStoreFrom
    {
        REMOTE,
        LOCAL
    }
}