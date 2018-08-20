using System;
using System.Collections.ObjectModel;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Net.Rest
{
    public interface ICountryRestApi
    {
        Collection<RawCountry> GetCountries();
        RawCountry GetCountryByISOCode(string isoCode);
    }
}