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
        
        public ICountryDataSource Build(DataSourceFrom dataSourceFrom)
        {
            switch (dataSourceFrom)
            {
                default:
                case DataSourceFrom.NETWORK:
                    return networkCountryDataSource;
                
                case DataSourceFrom.DISK:
                    return diskCountryDataSource;
            }
        }
    }
}