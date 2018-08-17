using xCleanWay.Remote.Net.Rest.Factory;

namespace xCleanWay.Remote.Net.Factory
{
    public abstract class CountryProviderFactory
    {
        public static CountryProviderFactory Create(NetworkAPI networkApi)
        {
            switch (networkApi)
            {
                default:
                case NetworkAPI.REST:
                    return new CountryRestProviderFactory();
            }
        }

        public abstract ICountryProvider Build();
    }
}