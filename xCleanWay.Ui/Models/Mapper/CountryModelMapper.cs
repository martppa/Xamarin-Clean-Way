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

using System.Collections.ObjectModel;
using xCleanWay.Core.Models;

namespace xCleanWay.Ui.Models.Mapper
{
    /// <summary>
    /// Country model mapper. This class transforms <see cref="Country"/> in core layer into
    /// <see cref="CountryModel"/> in ui layer.
    /// </summary>
    public class CountryModelMapper
    {
        public CountryModel Transform(Country country)
        {
            return new CountryModel(country.Name, country.IsoCode, country.FlagUrl);
        }

        public Collection<CountryModel> Transform(Collection<Country> countries)
        {
            var countryModels = new Collection<CountryModel>();
            foreach (var country in countries)
            {
                countryModels.Add(Transform(country));
            }

            return countryModels;
        }
    }
}