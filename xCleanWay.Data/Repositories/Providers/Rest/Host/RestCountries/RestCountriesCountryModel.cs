using xCleanWay.Data.Repositories.Providers.RawModels;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries
{
    public class RestCountriesCountryModel : RawCountry
    {
        public string name { get; set; }
        public string alpha2Code { get; set; }
        public string flag { get; set; }


        public override string GetName()
        {
            return name;
        }

        public override string GetIsoCode()
        {
            return alpha2Code;
        }

        public override string GetFlagUrl()
        {
            return flag;
        }
    }
}