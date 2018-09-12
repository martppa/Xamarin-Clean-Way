using System.Reactive.Concurrency;

namespace xCleanWay.Core.Threading
{
    public interface IExecutionThread
    {
        IScheduler GetScheduler();
    }

}