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
using Android.App;
using Android.OS;
using Android.Widget;
using xCleanWay.Android.Di;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

namespace xCleanWay.Android
{
    [Activity(Label = "xCleanWay.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ICountryListView
    {
        private ICountryListPresenter presenter;
        private ListView countryListView;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            countryListView = FindViewById<ListView>(Resource.Id.CountriesListView);

            InjectPresenter();
            InitPresenter();
            RequestCountries();
        }

        private void InjectPresenter()
        {
            Injector.GetInstance().Inject(out presenter);
        }

        private void InitPresenter()
        {
            presenter.SetView(this);
            presenter.Init();
        }

        private void RequestCountries()
        {
            presenter.RequestCountries();
        }

        public void ShowInfoMessage(string message)
        {
            ShowToast(message);
        }

        public void ShowWarningMessage(string message)
        {
            ShowToast(message);
        }

        public void ShowErrorMessage(string message)
        {
            ShowToast(message);
        }

        public void RenderCountries(Collection<CountryModel> countries)
        {
            countryListView.Adapter = new CountryAdapter(this, countries);
            countryListView.DeferNotifyDataSetChanged();
        }

        private void ShowToast(String message)
        {
            Toast.MakeText(this, message, ToastLength.Long);
        }
    }
}