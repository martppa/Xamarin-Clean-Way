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

using xCleanWay.Core.Interactors.Country;
using xCleanWay.Ui.Models.Mapper;
using xCleanWay.Ui.Views;

namespace xCleanWay.Ui.Presenters.Country
{
    /// <summary>
    /// This presenter will control any view that renders a list of
    /// countries
    /// </summary>
    public class CountryListPresenter : ICountryListPresenter
    {
        private ICountryListView view;
        private GetCountries getCountries;
        private CountryModelMapper countryModelMapper;

        public CountryListPresenter(GetCountries getCountries, CountryModelMapper countryModelMapper)
        {
            this.getCountries = getCountries;
            this.countryModelMapper = countryModelMapper;
        }
        
        public void Init()
        {
            // Unused
        }

        public void Pause()
        {
            // Unused
        }

        public void Resume()
        {
            // Unused
        }

        public void Finish()
        {
            getCountries.Dispose();
        }

        public void SetView(ICountryListView countryListView)
        {
            view = countryListView;
        }

        public void RequestCountries()
        {
            getCountries.Execute(
                onNext: countries => { view.RenderCountries(countryModelMapper.Transform(countries)); },
                onError: error => view.ShowErrorMessage(error.Message),
                onCompleted: () => { }, parameters: null);
        }
    }
}