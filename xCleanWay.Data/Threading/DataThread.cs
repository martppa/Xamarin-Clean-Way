using System.Reactive.Concurrency;
using xCleanWay.Core.Threading;

namespace xCleanWay.Data.Threading
{
    /// <summary>
    ///     Execution thread for data handling
    /// </summary>
    public class DataThread : IDataThread
    {
        public IScheduler GetScheduler() => NewThreadScheduler.Default;
    }
}