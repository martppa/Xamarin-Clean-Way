namespace xCleanWay.Remote.Net.Rest.Factory
{
    public class RestCountryProviderFactory : CountryProviderFactory
    {
        public override ICountryProvider Build()
        {
            return new RestCountryProvider();
        }
    }
}