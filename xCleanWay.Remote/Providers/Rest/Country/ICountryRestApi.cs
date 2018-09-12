using System.Collections.ObjectModel;
using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Providers.Rest.Country
{
    public interface ICountryRestApi
    {
        Collection<RawCountry> GetCountries();
        RawCountry GetCountryByISOCode(string isoCode);
    }
}