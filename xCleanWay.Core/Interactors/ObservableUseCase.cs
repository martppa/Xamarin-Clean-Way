using System;
using System.Reactive.Linq;
using xCleanWay.Core.Threading;

namespace xCleanWay.Core.Interactors
{
    public abstract class ObservableUseCase<T, Parameters> : UseCase
    {
        private IExecutionThread uiThread;
        private IExecutionThread workerThread;

        public ObservableUseCase(IExecutionThread uiThread, IExecutionThread workerThread)
        {
            this.uiThread = uiThread;
            this.workerThread = workerThread;
        }

        protected abstract IObservable<T> BuildUseCaseObservable(Parameters parameters);

        public void Execute(Action<T> onNext, Action<Exception> onError, Action onCompleted, Parameters parameters)
        {
            AddDisposable(BuildUseCaseObservable(parameters)
                .SubscribeOn(workerThread.GetScheduler())
                .ObserveOn(uiThread.GetScheduler())
                .Subscribe(onNext, onError, onCompleted));
        }
    }

}