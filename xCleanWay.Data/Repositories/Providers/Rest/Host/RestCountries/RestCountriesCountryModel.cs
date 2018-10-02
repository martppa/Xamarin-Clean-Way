using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries
{
    public class RestCountriesCountryModel : ICountryEntity
    {
        public string name { get; set; }
        public string alpha2Code { get; set; }
        public string flag { get; set; }

        public string Name => name;
        public string IsoCode => alpha2Code;
        public string FlagUrl => flag;
    }
}