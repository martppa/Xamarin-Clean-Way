/*
 * Copyright 2018 Humberto Martín Dieppa, Open source project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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