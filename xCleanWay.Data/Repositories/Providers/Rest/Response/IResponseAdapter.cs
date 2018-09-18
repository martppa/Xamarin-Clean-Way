namespace xCleanWay.Data.Repositories.Providers.Rest.Response
{
    public interface IResponseAdapter<out Content>
    {
        ResponseStatus GetStatus();
        string GetErrorMessage();
        Content GetContent();
    }

    public enum ResponseStatus
    {
        OK,
        ERROR
    }
}