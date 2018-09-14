using xCleanWay.Remote.Providers.Rest;

namespace xCleanWay.Data.Repositories.Providers.Country.Rest.Host.RestCountries
{
    public class RestCountriesResponse<C>
    {
        private C content;
        private ResponseStatus responseStatus;
        private string errorMessage;

        public RestCountriesResponse()
        {
            errorMessage = string.Empty;
            responseStatus = ResponseStatus.OK;
        }

        public RestCountriesResponse(ResponseStatus responseStatus, string errorMessage)
        {
            this.errorMessage = errorMessage;
            this.responseStatus = responseStatus;
        }
        
        public RestCountriesResponse(ResponseStatus responseStatus, C content)
        {
            errorMessage = string.Empty;
            this.content = content;
            this.responseStatus = responseStatus;
        }

        public C Content
        {
            get => content;
            set => content = value;
        }

        public ResponseStatus ResponseStatus
        {
            get => responseStatus;
            set => responseStatus = value;
        }

        public string ErrorMessage
        {
            get => errorMessage;
            set => errorMessage = value;
        }
    }
}