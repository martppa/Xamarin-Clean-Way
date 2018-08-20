namespace xCleanWay.Ui.Models
{
    public class CountryModel
    {
        private string name;
        private string isoCode;

        public CountryModel(string name, string isoCode)
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