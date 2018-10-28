using System.Collections;
using System.Collections.Generic;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Cache
{
    public interface ICountryCache
    {
        bool HasExpired();
        void save(List<ICountryEntity> countryEntityList);
        List<ICountryEntity> get();
    }
}