using System;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net
{
    public interface ICountryProvider
    {
        IObservable<Collection<RawCountry>> GetCountries();
        IObservable<RawCountry> getCountryByISOCode(string isoCode);
    }
}