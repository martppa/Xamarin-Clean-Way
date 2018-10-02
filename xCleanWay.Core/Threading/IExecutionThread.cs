using System.Reactive.Concurrency;

namespace xCleanWay.Core.Threading
{
    /// <summary>
    /// Execution base interface
    /// </summary>
    public interface IExecutionThread
    {
        IScheduler GetScheduler();
    }

}