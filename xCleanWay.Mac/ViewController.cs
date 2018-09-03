using System;
using System.Collections.ObjectModel;
using AppKit;
using Foundation;
using xCleanWay.Di;
using xCleanWay.Di.Factory;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

namespace xCleanWay.Mac
{
    public partial class ViewController : NSViewController, ICountryListView
    {
        private readonly Injector injector;
        private ICountryListPresenter countryListPresenter;
        
        public ViewController(IntPtr handle) : base(handle)
        {
            injector = InjectorFactory
                .Create(InjectorFactory
                    .InjectorConfiguration.MAC_INJECTOR_CONFIG).Build();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            InjectPresenter();
            InitPresenter();
            RequestCountries();
        }

        private void InjectPresenter()
        {
            injector.Inject(out countryListPresenter);
        }

        private void InitPresenter()
        {
            countryListPresenter.Init();
        }

        private void RequestCountries()
        {
            countryListPresenter.RequestCountries();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        public void ShowInfoMessage(string message)
        {
            //throw new NotImplementedException();
        }

        public void ShowWarningMessage(string message)
        {
            //throw new NotImplementedException();
        }

        public void ShowErrorMessage(string message)
        {
            //throw new NotImplementedException();
        }

        public void RenderCountries(Collection<CountryModel> countries)
        {
            //throw new NotImplementedException();
        }
    }
}
