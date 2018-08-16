namespace xCleanWay.Data.Repositories.DataStores.Factory
{
    public interface ISimpleSettingsDataStoreFactory
    {
        ISettingsDataStore Build(DataStoreFrom dataSourceFrom);
    }
}