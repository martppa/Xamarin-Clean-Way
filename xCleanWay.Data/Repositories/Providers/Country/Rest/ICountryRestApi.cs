using System.Collections.ObjectModel;
using xCleanWay.Data.Repositories.Providers.RawModels;

namespace xCleanWay.Remote.Providers.Rest.Country
{
    public interface ICountryRestApi
    {
        Collection<RawCountry> GetCountries();
        RawCountry GetCountryByISOCode(string isoCode);
    }
}