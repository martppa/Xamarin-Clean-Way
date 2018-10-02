using System;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataSources
{
    public interface ICountryDataSource
    {
        IObservable<Collection<ICountryEntity>> GetCountries();
        IObservable<ICountryEntity> getCountryByISOCode(string isoCode);
    }
}