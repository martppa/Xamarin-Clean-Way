namespace xCleanWay.Data.Repositories.DataSource.Factory
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
        
        public ICountryDataSource Build(SourceType sourceType)
        {
            switch (sourceType)
            {
                default:
                case SourceType.NETWORK:
                    return networkCountryDataSource;
                
                case SourceType.DISK:
                    return diskCountryDataSource;
            }
        }
    }
}