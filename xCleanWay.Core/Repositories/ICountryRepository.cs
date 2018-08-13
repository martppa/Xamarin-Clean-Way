using System;
using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Core.Repositories
{
    public interface ICountryRepository
    {
        IObservable<Collection<Country>> GetCountries();
        IObservable<Country> getCountryByISOCode(string isoCode);
    }
}