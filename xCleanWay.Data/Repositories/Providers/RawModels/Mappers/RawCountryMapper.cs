using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.RawModels.Mappers
{
    public class RawCountryMapper
    {
        public CountryEntity Transform(RawCountry rawCountry)
        {
            return new CountryEntity(rawCountry.GetName(), rawCountry.GetIsoCode(), rawCountry.GetFlagUrl());
        }

        public Collection<CountryEntity> Transform(IList<RawCountry> rawCountries)
        {
            var countryEntities = new Collection<CountryEntity>();
            foreach (var rawCountry in rawCountries)
            {
                countryEntities.Add(Transform(rawCountry));
            }

            return countryEntities;
        }

        public Collection<RawCountry> Transform<T>(IList<T> collection) where T : RawCountry
        {
            var rawCountries = new Collection<RawCountry>();
            foreach (var t in collection)
            {
                rawCountries.Add(t);
            }

            return rawCountries;
        }
    }
}