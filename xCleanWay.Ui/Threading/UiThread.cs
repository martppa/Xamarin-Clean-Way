using System.Reactive.Concurrency;
using ReactiveUI;
using xCleanWay.Core.Threading;

namespace xCleanWay.Ui.Threading
{
    public class UiThread : IExecutionThread
    {
        public IScheduler GetScheduler()
        {
            return RxApp.MainThreadScheduler;
        }
    }
}