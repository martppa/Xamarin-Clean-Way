using xCleanWay.Remote.Providers.Rest;

namespace xCleanWay.Data.Repositories.Providers.Country.Rest.Host.RestCountries
{
    public class RestCountriesResponseAdapter<Content> : IResponseAdapter<Content> where Content : class
    {
        private readonly RestCountriesResponse<Content> response;

        public RestCountriesResponseAdapter(RestCountriesResponse<Content> restCountriesResponse)
        {
            response = restCountriesResponse;
        }
        
        public ResponseStatus GetStatus()
        {
            return response?.ResponseStatus ?? ResponseStatus.ERROR;
        }

        public string GetErrorMessage()
        {
            return response?.ErrorMessage ?? string.Empty;
        }

        public Content GetContent()
        {
            return response?.Content;
        }
    }
}