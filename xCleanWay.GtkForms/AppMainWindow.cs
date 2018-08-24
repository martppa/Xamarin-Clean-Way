using System;
using System.Collections.ObjectModel;
using Gtk;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

namespace xCleanWay.GtkForms
{
    public partial class AppMainWindow : Gtk.Window, ICountryListView
    {
        private ICountryListPresenter presenter;

        public AppMainWindow(ICountryListPresenter presenter)
            : base(Gtk.WindowType.Toplevel)
        {
            Build();
            this.presenter = presenter;
            InitPresenter();
        }

        private void InitPresenter()
        {
            presenter.Init();
        }

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        public void ShowInfoMessage(string message)
        {
            new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, message).Show();
        }

        public void ShowWarningMessage(string message)
        {
            new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, message).Show();
        }

        public void ShowErrorMessage(string message)
        {
            new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, message).Show();
        }

        public void RenderCountries(Collection<CountryModel> countries)
        {
            throw new NotImplementedException();
        }
    }
}
