namespace xCleanWay.Data.Repositories.DataSources.Suppliers
{
    public interface ICountryDataSourcesSupplier
    {
        ICountryDataSource GetCountryDataSource(CountryDataSourceFrom countryDataSourceFrom);
    }

    public enum CountryDataSourceFrom
    {
        REMOTE,
        LOCAL
    }
}