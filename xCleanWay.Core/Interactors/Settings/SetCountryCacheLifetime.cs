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
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.Settings
{
    /// <summary>
    /// This use case is responsible of setting a specific cache life time
    /// for countries stored in local disk
    /// </summary>
    public class SetCountryCacheLifeTime : CompletableUseCase<SetCountryCacheLifeTime.Params>
    {
        private readonly ISettingsRepository settingsRepository;

        public SetCountryCacheLifeTime(IUiThread uiThread, IDataThread workerThread, 
            ISettingsRepository settingsRepository) : base(uiThread, workerThread)
        {
            this.settingsRepository = settingsRepository;
        }

        protected override IObservable<None> BuildUseCaseObservable(Params parameters)
        {
            return settingsRepository.SetCacheLifeTimeInMillis(parameters.CountryCacheLifetime);
        }
        
        /// <summary>
        /// Params class is intended to hold parameters passed to the
        /// use case, as in this case it will deal with the cache lifetime
        /// with will be stored in disk.
        /// </summary>
        public class Params
        {
            private Params(long countryCacheLifetime)
            {
                this.CountryCacheLifetime = countryCacheLifetime;
            }

            public static Params ForValue(long countryCacheLifetime)
            {
                return new Params(countryCacheLifetime);
            }

            public long CountryCacheLifetime { get; }
        }
    }
}