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

namespace xCleanWay.Ui.Models
{
    /// <summary>
    /// Country model in the UI layer
    /// </summary>
    public class CountryModel
    {
        private string name;
        private string isoCode;
        private string flagUrl;

        public CountryModel(string name, string isoCode, string flagUrl)
        {
            this.name = name;
            this.isoCode = isoCode;
            this.flagUrl = flagUrl;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string IsoCode
        {
            get => isoCode;
            set => IsoCode = value;
        }

        public string FlagUrl
        {
            get => flagUrl;
            set => flagUrl = value;
        }
    }
}