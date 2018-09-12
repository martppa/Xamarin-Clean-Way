using System;
using System.Reactive.Disposables;

namespace xCleanWay.Core.Interactors
{
    /// <summary>
    /// Use case's base class
    /// </summary>
    public abstract class UseCase
    {
        private CompositeDisposable disposables;

        public UseCase()
        {
            disposables = new CompositeDisposable();
        }

        public virtual void Dispose()
        {
            if (!disposables.IsDisposed)
                disposables.Dispose();
        }

        public virtual void AddDisposable(IDisposable disposable)
        {
            disposables.Add(disposable);
        }
    }

}