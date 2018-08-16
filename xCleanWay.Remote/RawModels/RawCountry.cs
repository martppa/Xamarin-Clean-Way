namespace xCleanWay.Remote.RawModels
{
    public class RawCountry
    {
        private string name;
        private string alfa2Code;
        private string alfa3Code;

        public RawCountry(string name, string alfa2Code, string alfa3Code)
        {
            this.name = name;
            this.alfa2Code = alfa2Code;
            this.alfa3Code = alfa3Code;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Alfa2Code
        {
            get => alfa2Code;
            set => alfa2Code = value;
        }

        public string Alfa3Code
        {
            get => alfa3Code;
            set => alfa3Code = value;
        }
    }
}