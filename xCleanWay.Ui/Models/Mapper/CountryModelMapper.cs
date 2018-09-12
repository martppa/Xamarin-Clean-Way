using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Ui.Models.Mapper
{
    public class CountryModelMapper
    {
        public CountryModel Transform(Country country)
        {
            return new CountryModel(country.Name, country.IsoCode, country.FlagUrl);
        }

        public Collection<CountryModel> Transform(Collection<Country> countries)
        {
            var countryModels = new Collection<CountryModel>();
            foreach (var country in countries)
            {
                countryModels.Add(Transform(country));
            }

            return countryModels;
        }
    }
}