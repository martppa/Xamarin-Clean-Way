namespace xCleanWay.Data.Repositories.DataSource.Factory
{
    public interface ISimpleCountryDataSourceFactory
    {
        ICountryDataSource Build(SourceType sourceType);
    }

    public enum SourceType
    {
        NETWORK,
        DISK
    }
}