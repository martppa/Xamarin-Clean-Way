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
using xCleanWay.Core.Models;
using xCleanWay.Core.Repositories;
using System.Collections.ObjectModel;
using xCleanWay.Data.Entities.Mappers;
using xCleanWay.Data.Repositories.DataSources.Factory;

namespace xCleanWay.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ICountryDataSourceSimpleFactory countryDataSourceSimpleFactory;
        private readonly CountryEntityMapper countryEntityMapper;
        
        public CountryRepository(ICountryDataSourceSimpleFactory countryDataSourceSimpleFactory, 
            CountryEntityMapper countryEntityMapper)
        {
            this.countryDataSourceSimpleFactory = countryDataSourceSimpleFactory;
            this.countryEntityMapper = countryEntityMapper;
        }

        public IObservable<Collection<Country>> GetCountries()
        {
            var countryDataSource = countryDataSourceSimpleFactory.Build();
            return countryDataSource.GetCountries()
                .Select(country => countryEntityMapper.Transform(country));
        }

        public IObservable<Country> getCountryByISOCode(string isoCode)
        {
            var countryDataSource = countryDataSourceSimpleFactory.Build();
            return countryDataSource.getCountryByISOCode(isoCode)
                .Select(country => countryEntityMapper.Transform(country));
        }
    }
}