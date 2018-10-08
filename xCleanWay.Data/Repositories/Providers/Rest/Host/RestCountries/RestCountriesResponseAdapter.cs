using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries
{
    /// <summary>
    ///     This class is intended to transform RestCountries host's response
    ///     into a standard readable response
    /// </summary>
    public class RestCountriesResponseAdapter : IResponseAdapter<RestCountriesResponse>
    {
        private readonly ResponseStatus responseStatus;
        private readonly string errorMessage;
        private readonly RestCountriesResponse restCountriesResponse;
        
        public RestCountriesResponseAdapter(RestCountriesResponse restCountriesResponse) 
        {
            this.restCountriesResponse = restCountriesResponse;
        }

        public RestCountriesResponseAdapter(ResponseStatus responseStatus, string errorMessage)
        {
            this.responseStatus = responseStatus;
            this.errorMessage = errorMessage;
        }

        public ResponseStatus GetStatus()
        {
            return responseStatus;
        }

        public string GetErrorMessage()
        {
            return errorMessage;
        }

        public RestCountriesResponse GetContent()
        {
            return restCountriesResponse;
        }
    }
}