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
    /// This use case is responsible of retrieving program's settings
    /// from data layer
    /// </summary>
    public class GetSettings : ObservableUseCase<Models.Settings, None>
    {
        private readonly ISettingsRepository settingsRepository;
        
        public GetSettings(IUiThread uiThread, IDataThread workerThread, 
            ISettingsRepository settingsRepository) : base(uiThread, workerThread)
        {
            this.settingsRepository = settingsRepository;
        }

        protected override IObservable<Models.Settings> BuildUseCaseObservable(None parameters)
        {
            return settingsRepository.GetSettings();
        }
    }
}