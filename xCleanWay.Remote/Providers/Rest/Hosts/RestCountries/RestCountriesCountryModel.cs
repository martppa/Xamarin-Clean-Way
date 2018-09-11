using xCleanWay.Remote.RawModels;

namespace xCleanWay.Remote.Providers.Rest.Hosts.RestCountries
{
    public class RestCountriesCountryModel : RawCountry
    {
        public string name { get; set; }
        public string alpha2Code { get; set; }
        public string flag { get; set; }
        public override string GetName() => name;
        public override string GetIsoCode() => alpha2Code;
        public override string GetFlagUrl() => flag;
    }
}