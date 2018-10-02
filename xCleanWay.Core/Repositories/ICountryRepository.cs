using System;
using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Core.Repositories
{
    /// <summary>
    /// Country repository access interface to be implemented in the data layer
    /// </summary>
    public interface ICountryRepository
    {
        IObservable<Collection<Country>> GetCountries();
        IObservable<Country> getCountryByISOCode(string isoCode);
    }
}