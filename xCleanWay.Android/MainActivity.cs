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