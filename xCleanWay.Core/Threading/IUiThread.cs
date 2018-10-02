namespace xCleanWay.Core.Threading
{
    /// <summary>
    /// UI thread access interface to handle incoming data from
    /// data layer and draw them in the UI. Must be implemented or extended in UI layer
    /// or beyond.
    /// </summary>
    public interface IUiThread : IExecutionThread {}
}