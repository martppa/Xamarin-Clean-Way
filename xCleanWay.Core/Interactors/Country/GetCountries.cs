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
using System.Collections.ObjectModel;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.Country
{
    /// <summary>
    /// This use case is the responsible of retrieving country objects
    /// from data layer
    /// </summary>
    public class GetCountries : ObservableUseCase<Collection<Models.Country>, None>
    {
        private readonly ICountryRepository countryRepository;
        
        public GetCountries(IUiThread uiThread, IDataThread workerThread, 
            ICountryRepository countryRepository) : base(uiThread, workerThread)
        {
            this.countryRepository = countryRepository;
        }

        protected override IObservable<Collection<Models.Country>> BuildUseCaseObservable(None parameters)
        {
            return countryRepository.GetCountries();
        }
    }
}