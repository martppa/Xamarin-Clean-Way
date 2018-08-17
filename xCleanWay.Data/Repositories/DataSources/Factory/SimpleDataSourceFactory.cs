namespace xCleanWay.Data.Repositories.DataSources.Factory
{
    public class SimpleDataSourceFactory : ISimpleCountryDataSourceFactory
    {
        private ICountryDataSource networkCountryDataSource;
        private ICountryDataSource diskCountryDataSource;
        
        public SimpleDataSourceFactory(ICountryDataSource networkCountryDataSource,
            ICountryDataSource diskCountryDataSource)
        {
            this.networkCountryDataSource = networkCountryDataSource;
            this.diskCountryDataSource = diskCountryDataSource;
        }
        
        public ICountryDataSource Build(DataSourceType dataSourceType)
        {
            switch (dataSourceType)
            {
                default:
                case DataSourceType.NETWORK:
                    return networkCountryDataSource;
                
                case DataSourceType.DISK:
                    return diskCountryDataSource;
            }
        }
    }
}