using xCleanWay.Ui.Views;

namespace xCleanWay.Ui.Presenters
{
    public interface ICountryListPresenter : IPresenter
    {
        void RequestCountries();
        void SetView(ICountryListView countryListView);
    }
}