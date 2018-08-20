namespace xCleanWay.Remote.Providers.Rest
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