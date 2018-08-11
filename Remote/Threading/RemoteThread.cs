using System.Reactive.Concurrency;
using xCleanWay.Data.Threading;

namespace Remote.Threading
{
    public class RemoteThread : IDataThread
    {
        public IScheduler GetScheduler()
        {
            return TaskPoolScheduler.Default;
        }
    }
}