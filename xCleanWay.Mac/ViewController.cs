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
using AppKit;
using Foundation;
using GameKit;
using xCleanWay.Mac.Di;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

namespace xCleanWay.Mac
{
    public partial class ViewController : NSViewController, ICountryListView
    {
        
        private ICountryListPresenter countryListPresenter;
        
        public ViewController(IntPtr handle) 
            : base(handle)
        {
            
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
            CountryTableView.DataSource = new CountryTableDataSource(countries);
            CountryTableView.Delegate = new CountryTableDelegate(countries);
        }
    }

    class CountryTableDataSource : NSTableViewDataSource
    {
        private Collection<CountryModel> countries;

        public CountryTableDataSource(Collection<CountryModel> countries)
        {
            this.countries = countries;
        }

        public override nint GetRowCount (NSTableView tableView)
        {
            return countries.Count;
        }
    }

    class CountryTableDelegate : NSTableViewDelegate
    {
        private const string identifier = "AnyID";
        
        private Collection<CountryModel> countries;
        
        public CountryTableDelegate(Collection<CountryModel> countries)
        {
            this.countries = countries;
        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            NSTextField view = (NSTextField)tableView.MakeView (identifier, this);
            if (view == null) {
                view = new NSTextField ();
                view.Identifier = identifier;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }
            
            switch (tableColumn.Title)
            {
                case "Name":
                    view.StringValue = (NSString) countries[(int) row].Name;
                    break;
                case "Iso":
                    view.StringValue = (NSString) countries[(int) row].IsoCode;
                    break;
            }

            return view;		
        }
    }
}
