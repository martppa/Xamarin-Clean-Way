using System.Collections.ObjectModel;
using Android.App;
using Android.Widget;
using Android.OS;
using xCleanWay.Di;
using xCleanWay.Di.Factory;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

namespace xCleanWay.Android
{
    [Activity(Label = "xCleanWay.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ICountryListView
    {
        private Injector injector;
        private ICountryListPresenter countryListPresenter;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            injector = InjectorFactory
                .Create(InjectorFactory
                    .InjectorConfiguration.ANDROID_INJECTOR_CONFIG).Build();
            
            InjectPresenter();
            InitPresenter();
            RequestCountries();

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        private void InjectPresenter()
        {
            injector.Inject(out countryListPresenter);
        }

        private void InitPresenter()
        {
            countryListPresenter.SetView(this);
            countryListPresenter.Init();
        }

        private void RequestCountries()
        {
            countryListPresenter.RequestCountries();
        }

        public void ShowInfoMessage(string message)
        {
            throw new System.NotImplementedException();
        }

        public void ShowWarningMessage(string message)
        {
            throw new System.NotImplementedException();
        }

        public void ShowErrorMessage(string message)
        {
            throw new System.NotImplementedException();
        }

        public void RenderCountries(Collection<CountryModel> countries)
        {
            throw new System.NotImplementedException();
        }
    }
}