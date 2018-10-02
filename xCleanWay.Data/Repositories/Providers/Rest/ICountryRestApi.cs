using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest
{
    public interface ICountryRestApi
    {
        List<ICountryEntity> GetCountries();
        ICountryEntity GetCountryByISOCode(string isoCode);
    }
}