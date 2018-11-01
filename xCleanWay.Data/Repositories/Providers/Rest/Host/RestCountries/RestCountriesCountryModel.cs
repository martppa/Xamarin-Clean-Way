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

using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.RestCountries
{
    /// <summary>
    ///     Basic Country model of <see cref="https://restcountries.eu"/>
    /// </summary>
    public class RestCountriesCountryModel : ICountryEntity
    {
        public string name { get; set; }
        public string alpha2Code { get; set; }
        public string flag { get; set; }

        public RestCountriesCountryModel() {}

        public RestCountriesCountryModel(string name, string alpha2Code, string flag)
        {
            this.name = name;
            this.alpha2Code = alpha2Code;
            this.flag = flag;
        }

        // Field mapping for the interface
        public string Name => name;
        public string IsoCode => alpha2Code;
        public string FlagUrl => flag;
    }
}