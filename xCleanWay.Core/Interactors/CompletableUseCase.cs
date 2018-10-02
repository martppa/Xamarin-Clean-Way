using System;
using System.Reactive.Linq;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors
{
    /// <summary>
    /// Completable use case base class. Completable use cases are use cases where
    /// no data is retrieved and only an action to complete is required
    /// </summary>
    /// <typeparam name="Parameters">Parameters to complete such an action</typeparam>
    public abstract class CompletableUseCase<Parameters> : AsyncUseCase
    {
        protected CompletableUseCase(IUiThread uiThread, IExecutionThread workerThread) 
            : base(uiThread, workerThread) {}

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