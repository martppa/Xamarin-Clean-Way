using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers
{
    public interface ICountryProvider
    {
        List<ICountryEntity> GetCountries();
        ICountryEntity GetCountryByISOCode(string isoCode);
    }
}