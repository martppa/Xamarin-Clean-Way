using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    public class GroupKtResponseAdapter<Content> : IResponseAdapter<Content>
    {
        private readonly GroupKtRestResponse<Content> groupKtRestResponse;
        private string errorMessage;
        private ResponseStatus responseStatus;

        public GroupKtResponseAdapter(GroupKtRestResponse<Content> groupKtRestResponse)
        {
            this.groupKtRestResponse = groupKtRestResponse;
        }
        
        public GroupKtResponseAdapter(ResponseStatus responseStatus, string errorMessage)
        {
            this.errorMessage = errorMessage;
            this.responseStatus = responseStatus;
        }
        
        public ResponseStatus GetStatus()
        {
            return responseStatus;
        }

        public string GetErrorMessage()
        {
            return errorMessage;
        }

        public Content GetContent()
        {
            return groupKtRestResponse.Content;
        }
    }
}