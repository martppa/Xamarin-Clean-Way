using xCleanWay.Remote.Providers.Rest;
using xCleanWay.Remote.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Country.Rest.Host.RestCountries
{
    public class RestCountriesResponseAdapter<Content> : RestResponseAdapter<Content, RestCountriesResponse<Content>> where Content : class
    {
        public RestCountriesResponseAdapter(RestCountriesResponse<Content> restCountriesResponse)
            : base(restCountriesResponse) {}

        public override ResponseStatus GetStatus()
        {
            return response?.ResponseStatus ?? ResponseStatus.ERROR;
        }

        public override string GetErrorMessage()
        {
            return response?.ErrorMessage ?? string.Empty;
        }

        public override Content GetContent()
        {
            return response?.Content;
        }
    }
}