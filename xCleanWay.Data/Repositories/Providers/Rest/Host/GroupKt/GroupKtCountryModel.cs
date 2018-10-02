using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    public class GroupKtCountryModel : ICountryEntity
    {
        public string name { get; set; }
        public string alpha2_code { get; set; }
        public string alpha3_code { get; set; }

        public string Name => name;
        public string IsoCode => alpha2_code;
        public string FlagUrl => alpha3_code;
    }
}