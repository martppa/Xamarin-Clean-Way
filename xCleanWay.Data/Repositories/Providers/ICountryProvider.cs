using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers
{
    public interface ICountryProvider
    {
        Collection<CountryEntity> GetCountries();
        CountryEntity GetCountryByISOCode(string isoCode);
    }
}