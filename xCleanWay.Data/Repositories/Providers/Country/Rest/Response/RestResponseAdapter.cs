namespace xCleanWay.Remote.Providers.Rest.Response
{
    public abstract class RestResponseAdapter<Content, Response> : IResponseAdapter<Content>
    {
        protected readonly Response response;

        protected RestResponseAdapter(Response response)
        {
            this.response = response;
        }

        public abstract ResponseStatus GetStatus();
        public abstract string GetErrorMessage();
        public abstract Content GetContent();
    }
}