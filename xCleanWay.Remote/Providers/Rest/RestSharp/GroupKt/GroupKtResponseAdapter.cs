namespace xCleanWay.Remote.Providers.Rest.RestSharp.GroupKt
{
    public class GroupKtResponseAdapter<Content> : IResponseAdapter<Content>
    {
        private GroupKtRestResponse<Content> groupKtRestResponse;

        public GroupKtResponseAdapter(GroupKtRestResponse<Content> groupKtRestResponse)
        {
            this.groupKtRestResponse = groupKtRestResponse;
        }
        
        public ResponseStatus GetStatus()
        {
            return groupKtRestResponse.ErrorMessage == null ? ResponseStatus.OK : ResponseStatus.ERROR;
        }

        public string GetErrorMessage()
        {
            return groupKtRestResponse.ErrorMessage;
        }

        public Content GetContent()
        {
            return groupKtRestResponse.Content;
        }
    }
}