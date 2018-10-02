using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries
{
    /// <summary>
    ///     This class is intended to transform RestCountries host's response
    ///     into a standard readable response
    /// </summary>
    public class RestCountriesResponseAdapter : RestResponseAdapter<RestCountriesResponse, RestCountriesResponse>
    {
        private readonly ResponseStatus responseStatus;
        private readonly string errorMessage;
        
        public RestCountriesResponseAdapter(RestCountriesResponse restCountriesResponse)
            : base(restCountriesResponse) {}

        public RestCountriesResponseAdapter(ResponseStatus responseStatus, string errorMessage) 
            : base(new RestCountriesResponse())
        {
            this.responseStatus = responseStatus;
            this.errorMessage = errorMessage;
        }

        public override ResponseStatus GetStatus()
        {
            return responseStatus;
        }

        public override string GetErrorMessage()
        {
            return errorMessage;
        }

        public override RestCountriesResponse GetContent()
        {
            return response;
        }
    }
}