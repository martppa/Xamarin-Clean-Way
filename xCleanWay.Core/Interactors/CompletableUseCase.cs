using System;
using System.Reactive.Linq;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors
{
    public abstract class CompletableUseCase<Parameters> : UseCase
    {
        private readonly IExecutionThread uiThread;
        private readonly IExecutionThread workerThread;

        public CompletableUseCase(IExecutionThread uiThread, IExecutionThread workerThread)
        {
            this.uiThread = uiThread;
            this.workerThread = workerThread;
        }

        protected abstract IObservable<None> BuildUseCaseObservable(Parameters parameters);

        public void Execute(Action<Exception> onError, Action onCompleted, Parameters parameters)
        {
            AddDisposable(BuildUseCaseObservable(parameters)
                .SubscribeOn(workerThread.GetScheduler())
                .ObserveOn(uiThread.GetScheduler())
                .Subscribe(_ => { }, onError, onCompleted));
        }
    }

}