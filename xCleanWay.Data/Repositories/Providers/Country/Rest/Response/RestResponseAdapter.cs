namespace xCleanWay.Remote.Providers.Rest.Response
{
    public class RestResponseAdapter<Content, Response>
    {
        private Response response;

        public RestResponseAdapter(Response response)
        {
            this.response = response;
        }
    }
}