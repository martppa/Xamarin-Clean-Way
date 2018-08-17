namespace xCleanWay.Data.Repositories.DataSources.Factory
{
    public interface ISimpleCountryDataSourceFactory
    {
        ICountryDataSource Build(DataSourceType dataSourceType);
    }
}