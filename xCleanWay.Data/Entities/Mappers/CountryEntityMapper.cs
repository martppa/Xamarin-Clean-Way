using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Data.Entities.Mappers
{
    public class CountryEntityMapper
    {
        public Country transform(CountryEntity countryEntity)
        {
            return new Country(countryEntity.Name, countryEntity.Alfa2Code, countryEntity.Alfa3Code);
        }

        public Collection<Country> transform(Collection<CountryEntity> countryEntities)
        {
            Collection<Country> countries = new Collection<Country>();
            foreach (var countryEntity in countryEntities)
            {
                countries.Add(transform(countryEntity));
            }
            return countries;
        }
    }
}