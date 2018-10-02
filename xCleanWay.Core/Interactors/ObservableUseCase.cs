using System;
using System.Reactive.Linq;
using xCleanWay.Core.Threading;

namespace xCleanWay.Core.Interactors
{
    /// <summary>
    /// Observable use case base class which is intended to perform an action
    /// which returns one or many values.
    /// </summary>
    /// <typeparam name="T">Type of value to be retrieved</typeparam>
    /// <typeparam name="Parameters">Necessary parameters to perform the action</typeparam>
    public abstract class ObservableUseCase<T, Parameters> : AsyncUseCase
    {
        protected ObservableUseCase(IUiThread uiThread, IDataThread workerThread) 
            : base(uiThread, workerThread) {}

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