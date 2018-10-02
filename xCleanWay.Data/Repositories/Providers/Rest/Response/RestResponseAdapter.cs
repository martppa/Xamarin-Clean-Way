namespace xCleanWay.Data.Repositories.Providers.Rest.Response
{
    /// <summary>
    ///     Base adapter class for REST adapters
    /// </summary>
    /// <typeparam name="Content">
    ///     Response's raw content type
    /// </typeparam>
    /// <typeparam name="Response">
    ///     Response's type
    /// </typeparam>
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