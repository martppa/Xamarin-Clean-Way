using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers
{
    public interface ICountryProvider
    {
        Collection<ICountryEntity> GetCountries();
        ICountryEntity GetCountryByISOCode(string isoCode);
    }
}