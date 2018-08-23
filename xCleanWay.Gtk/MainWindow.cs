using System;
using System.Collections.ObjectModel;
using Gtk;
using xCleanWay.Di;
using xCleanWay.Di.Factory;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;

public partial class MainWindow : Gtk.Window, ICountryListView
{
    private Injector injector;
    private ICountryListPresenter presenter;
    
    public MainWindow() 
        : base(Gtk.WindowType.Toplevel)
    {
        Build();
        CallInjector();
        InjectPresenter();
        InitPresenter();
    }

    private void CallInjector()
    {
        injector = InjectorFactory
            .Create(InjectorFactory.InjectorConfiguration.GTK_INJECTOR_CONFIG).Build();
    }

    private void InjectPresenter()
    {
        injector.Inject(out presenter);
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
