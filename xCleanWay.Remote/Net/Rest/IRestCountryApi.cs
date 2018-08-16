using System;
using System.Collections.ObjectModel;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net.Rest
{
    public interface IRestCountryApi
    {
        IObservable<Collection<RawCountry>> GetCountries();
        IObservable<RawCountry> getCountryByISOCode(string isoCode);
    }
}