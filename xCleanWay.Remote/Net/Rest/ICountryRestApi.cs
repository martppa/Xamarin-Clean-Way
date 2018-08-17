using System;
using System.Collections.ObjectModel;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net.Rest
{
    public interface ICountryRestApi
    {
        IObservable<Collection<RawCountry>> GetCountries();
        IObservable<RawCountry> GetCountryByISOCode(string isoCode);
    }
}