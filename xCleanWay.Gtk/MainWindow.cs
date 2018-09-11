using System;
using System.Collections.ObjectModel;
using Gtk;
using xCleanWay.Gtk.Di;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

public partial class MainWindow : Gtk.Window, ICountryListView
{
    private ICountryListPresenter presenter;
    
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
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

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    public void ShowInfoMessage(string message)
    {
        MessageDialog messageDialog = new MessageDialog(this, 
            DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, message);
        //messageDialog.Show();
    }

    public void ShowWarningMessage(string message)
    {
        MessageDialog messageDialog = new MessageDialog(this, 
            DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, message);
        //messageDialog.Show();
    }

    public void ShowErrorMessage(string message)
    {
        MessageDialog messageDialog = new MessageDialog(this, 
            DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, message);
        //messageDialog.Show();
    }

    public void RenderCountries(Collection<CountryModel> countries)
    {
        //throw new NotImplementedException();
        Console.WriteLine(countries.Count);
    }
}
