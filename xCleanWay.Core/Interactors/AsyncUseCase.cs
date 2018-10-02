using xCleanWay.Core.Threading;

namespace xCleanWay.Core.Interactors
{
    /// <summary>
    /// Base asynchronous use case class
    /// </summary>
    public abstract class AsyncUseCase : UseCase
    {
        protected readonly IExecutionThread uiThread;
        protected readonly IExecutionThread workerThread;

        protected AsyncUseCase(IExecutionThread uiThread, IExecutionThread workerThread)
        {
            this.uiThread = uiThread;
            this.workerThread = workerThread;
        }
    }
}