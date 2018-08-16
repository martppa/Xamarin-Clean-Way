using xCleanWay.Remote.Net.Rest.Factory;

namespace xCleanWay.Remote.Net
{
    public abstract class CountryProviderFactory
    {
        public static CountryProviderFactory Create(NetworkAPI networkApi)
        {
            switch (networkApi)
            {
                default:
                case NetworkAPI.REST:
                    return new RestCountryProviderFactory();
            }
        }

        public abstract ICountryProvider Build();

        public enum NetworkAPI
        {
            REST
        }
    }
}