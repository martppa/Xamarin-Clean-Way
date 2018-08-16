namespace xCleanWay.Data.Entities
{
    public class CountryEntity
    {
        private string name;
        private string isoCode;

        public CountryEntity(string name, string isoCode)
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