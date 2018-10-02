using System.Collections.Generic;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest.Country
{
    public interface ICountryRestApi
    {
        List<ICountryEntity> GetCountries();
        ICountryEntity GetCountryByISOCode(string isoCode);
    }
}