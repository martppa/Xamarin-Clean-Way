using System.Collections.Generic;
using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Data.Entities.Mappers
{
    /// <summary>
    /// Country entity mapper. This class transforms <see cref="ICountryEntity"/> in data layer into
    /// <see cref="Country"/> in core layer.
    /// </summary>
    public class CountryEntityMapper
    {
        public Country Transform(ICountryEntity countryEntity)
        {
            return new Country(countryEntity.Name, countryEntity.IsoCode, countryEntity.FlagUrl);
        }

        public Collection<Country> Transform(List<ICountryEntity> countryEntities)
        {
            var countries = new Collection<Country>();
            foreach (var countryEntity in countryEntities)
            {
                countries.Add(Transform(countryEntity));
            }
            
            return countries;
        }
    }
}