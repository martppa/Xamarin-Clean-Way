using System.Reactive.Concurrency;
using xCleanWay.Core.Threading;

namespace xCleanWay.Data.Threading
{
    public class DataThread : IDataThread
    {
        public IScheduler GetScheduler() => NewThreadScheduler.Default;
    }
}