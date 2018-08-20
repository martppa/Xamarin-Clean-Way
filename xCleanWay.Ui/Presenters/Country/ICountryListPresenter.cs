using xCleanWay.Ui.Views;

namespace xCleanWay.Ui.Presenters
{
    public interface ICountryListPresenter : IPresenter
    {
        void requestCountries();
        void SetView(ICountryListView countryListView);
    }
}