namespace xCleanWay.Remote.Net.Rest.Factory
{
    public class CountryRestProviderFactory : CountryProviderFactory
    {
        public override ICountryProvider Build()
        {
            return new CountryRestProvider();
        }
    }
}