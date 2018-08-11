using System.Reactive.Concurrency;
using xCleanWay.Data.Threading;

namespace Persistence.Threading
{
    public class PersistenceThread : IDataThread
    {
        public IScheduler GetScheduler()
        {
            return TaskPoolScheduler.Default;
        }
    }
}