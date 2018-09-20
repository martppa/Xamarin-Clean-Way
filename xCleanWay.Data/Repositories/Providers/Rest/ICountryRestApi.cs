using System.Collections.ObjectModel;
using xCleanWay.Data.Repositories.Providers.RawModels;

namespace xCleanWay.Data.Repositories.Providers.Rest
{
    public interface ICountryRestApi
    {
        Collection<RawCountry> GetCountries();
        RawCountry GetCountryByISOCode(string isoCode);
    }
}