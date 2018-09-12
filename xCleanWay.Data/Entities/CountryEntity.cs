using System.Net.Http.Headers;

namespace xCleanWay.Data.Entities
{
    public class CountryEntity
    {
        private string name;
        private string isoCode;
        private string flagUrl;

        public CountryEntity(string name, string isoCode, string flagUrl)
        {
            this.name = name;
            this.isoCode = isoCode;
            this.flagUrl = flagUrl;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string IsoCode
        {
            get => isoCode;
            set => IsoCode = value;
        }

        public string FlagUrl
        {
            get => flagUrl;
            set => flagUrl = value;
        }
    }
}