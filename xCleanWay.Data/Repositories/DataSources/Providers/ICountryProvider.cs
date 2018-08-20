using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Remote.Net
{
    public interface ICountryProvider
    {
        Collection<CountryEntity> GetCountries();
        CountryEntity GetCountryByISOCode(string isoCode);
    }
}