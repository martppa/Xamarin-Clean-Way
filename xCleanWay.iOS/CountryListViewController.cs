using System;
using System.Collections.ObjectModel;
using Foundation;
using UIKit;
using xCleanWay.iOS.Di;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

namespace xCleanWay.iOS
{
    public partial class CountryListViewController : UIViewController, ICountryListView
    {
        private ICountryListPresenter countryListPresenter;

        public CountryListViewController() : base("CountryListViewController", null)
        {
        }

        private void InjectPresenter()
        {
            Injector.GetInstance().Inject(out countryListPresenter);
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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            InjectPresenter();
            InitPresenter();
            RequestCountries();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void RenderCountries(Collection<CountryModel> countries)
        {
            UITableView table = new UITableView(View.Bounds);
            table.Source = new CountryTableSource(countries);
            Add(table);
        }

        public void ShowInfoMessage(string message)
        {
            ShowAlert("Info", message);
        }

        public void ShowWarningMessage(string message)
        {
            ShowAlert("Warning", message);
        }

        public void ShowErrorMessage(string message)
        {
            ShowAlert("Error", message);
        }

        private void ShowAlert(string title, string message)
        {
            var okAlertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            PresentViewController(okAlertController, true, null);
        }
    }

    class CountryTableSource : UITableViewSource
    {
        Collection<CountryModel> countries;
        string CellIdentifier = "TableCell";

        public CountryTableSource(Collection<CountryModel> countries)
        {
            this.countries = countries;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return countries.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            CountryModel country = countries[indexPath.Row];
            string item = country.Name + " - " + country.IsoCode;
            
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item;

            return cell;
        }
    }
}

