using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Data.Entities.Mappers
{
    public class CountryEntityMapper
    {
        public Country transform(ICountryEntity countryEntity)
        {
            return new Country(countryEntity.Name, countryEntity.IsoCode, countryEntity.FlagUrl);
        }

        public Collection<Country> transform(Collection<ICountryEntity> countryEntities)
        {
            var countries = new Collection<Country>();
            foreach (var countryEntity in countryEntities)
            {
                countries.Add(transform(countryEntity));
            }
            
            return countries;
        }
    }
}