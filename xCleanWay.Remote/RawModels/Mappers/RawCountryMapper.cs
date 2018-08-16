using System.Collections.ObjectModel;
using System.Globalization;
using xCleanWay.Data.Entities;

namespace xCleanWay.Remote.RawModels.Mappers
{
    public class RawCountryMapper
    {
        public CountryEntity Transform(RawCountry rawCountry)
        {
            return new CountryEntity(rawCountry.Name, rawCountry.Alfa2Code);
        }

        public Collection<CountryEntity> Transform(Collection<RawCountry> rawCountries)
        {
            var countryEntities = new Collection<CountryEntity>();
            foreach (var rawCountry in rawCountries)
            {
                countryEntities.Add(Transform(rawCountry));
            }

            return countryEntities;
        }
    }
}