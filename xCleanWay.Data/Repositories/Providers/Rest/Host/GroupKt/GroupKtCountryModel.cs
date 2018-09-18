using xCleanWay.Data.Repositories.Providers.RawModels;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    public class GroupKtCountryModel : RawCountry
    {
        public string name { get; set; }
        public string alpha2_code { get; set; }
        public string alpha3_code { get; set; }

        public override string GetName() => name;
        public override string GetIsoCode() => alpha2_code;
        public override string GetFlagUrl() => alpha3_code;
    }
}