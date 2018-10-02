namespace xCleanWay.Core.Models
{
    /// <summary>
    /// Country model in the Core layer
    /// </summary>
    public class Country
    {
        private string name;
        private string isoCode;
        private string flagUrl;

        public Country(string name, string isoCode, string flagUrl)
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