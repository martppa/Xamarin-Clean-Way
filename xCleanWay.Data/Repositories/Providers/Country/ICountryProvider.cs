using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;
using xCleanWay.Data.Repositories.Providers.RawModels;

namespace xCleanWay.Data.Repositories.Providers.Country
{
    public interface ICountryProvider
    {
        Collection<CountryEntity> GetCountries();
        CountryEntity GetCountryByISOCode(string isoCode);
    }
}