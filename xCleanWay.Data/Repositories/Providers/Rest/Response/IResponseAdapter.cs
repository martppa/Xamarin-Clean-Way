namespace xCleanWay.Data.Repositories.Providers.Rest.Response
{
    /// <summary>
    ///     Response adapter interface. This class must be implemented
    ///     by a host specific adapters
    /// </summary>
    /// <typeparam name="Content">
    ///    Adapter's response content type
    /// </typeparam>
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