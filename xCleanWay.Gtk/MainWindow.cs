using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Gtk;
using xCleanWay.Gtk.Di;
using xCleanWay.Ui.Models;
using xCleanWay.Ui.Presenters;
using xCleanWay.Ui.Views;
using Application = Gtk.Application;
using TreeView = Gtk.TreeView;

public partial class MainWindow : Gtk.Window, ICountryListView
{
    private ICountryListPresenter presenter;

    private TreeView countriesView;
    
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        DrawWidgets();
        InjectPresenter();
        InitPresenter();
        RequestCountries();
    }

    private void DrawWidgets()
    {
        SetSizeRequest(800, 600);
        countriesView = new TreeView();
        countriesView.Show();
        ScrolledWindow scrolledWindow = new ScrolledWindow {countriesView};
        scrolledWindow.Show();
        Add(scrolledWindow);
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
        TreeViewColumn flagColumn = new TreeViewColumn {Title = "Flag"};
        countriesView.AppendColumn(flagColumn);
        TreeViewColumn nameColumn = new TreeViewColumn {Title = "Name"};
        countriesView.AppendColumn(nameColumn);
        TreeViewColumn isoColumn = new TreeViewColumn {Title = "ISO"};
        countriesView.AppendColumn(isoColumn);
        ListStore countryListStore = new ListStore (typeof (string), typeof (string), typeof(string));
        countriesView.Model = countryListStore;

        foreach (var countryModel in countries)
        {
            countryListStore.AppendValues(countryModel.FlagUrl, countryModel.Name, countryModel.IsoCode);
        }
        
        CellRendererText flagCellRendererText = new CellRendererText();
        flagColumn.PackStart(flagCellRendererText, true);
        CellRendererText nameCellRendererText = new CellRendererText();
        nameColumn.PackStart(nameCellRendererText, true);
        CellRendererText isoCellRendererText = new CellRendererText();
        isoColumn.PackStart(isoCellRendererText, true);
        
        flagColumn.AddAttribute(flagCellRendererText, "text", 0);
        nameColumn.AddAttribute(nameCellRendererText, "text", 1);
        isoColumn.AddAttribute(isoCellRendererText, "text", 2);
    }
}
