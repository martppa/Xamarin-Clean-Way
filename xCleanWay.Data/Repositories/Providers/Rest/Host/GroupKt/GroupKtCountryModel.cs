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

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    /// <summary>
    ///     Basic Country model of <see cref="http://services.groupkt.com"/>
    /// </summary>
    public class GroupKtCountryModel : ICountryEntity
    {
        public string name { get; set; }
        public string alpha2_code { get; set; }
        public string alpha3_code { get; set; }

        // Field mapping for the interface
        public string Name => name;
        public string IsoCode => alpha2_code;
        public string FlagUrl => alpha3_code;
    }
}