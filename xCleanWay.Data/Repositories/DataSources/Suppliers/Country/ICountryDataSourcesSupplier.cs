namespace xCleanWay.Data.Repositories.DataSources.Suppliers.Country
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