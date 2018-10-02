using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest
{
    public interface ICountryRestApi
    {
        Collection<ICountryEntity> GetCountries();
        ICountryEntity GetCountryByISOCode(string isoCode);
    }
}