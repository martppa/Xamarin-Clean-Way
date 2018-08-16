namespace xCleanWay.Core.Models
{
    public class Country
    {
        private string name;
        private string isoCode;

        public Country(string name, string isoCode)
        {
            this.name = name;
            this.isoCode = isoCode;
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
    }
}