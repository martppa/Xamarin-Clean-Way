using xCleanWay.Core.Interactors.Country.GetCountries;
using xCleanWay.Ui.Models.Mapper;
using xCleanWay.Ui.Views;

namespace xCleanWay.Ui.Presenters
{
    public class CountryListPresenter : ICountryListPresenter
    {
        private ICountryListView view;
        private GetCountries getCountries;
        private CountryModelMapper countryModelMapper;

        public CountryListPresenter(GetCountries getCountries, CountryModelMapper countryModelMapper)
        {
            this.getCountries = getCountries;
            this.countryModelMapper = countryModelMapper;
        }
        
        public void Init()
        {
            // Unused
        }

        public void Pause()
        {
            // Unused
        }

        public void Resume()
        {
            // Unused
        }

        public void Finish()
        {
            // Unused
        }

        public void SetView(ICountryListView countryListView)
        {
            view = countryListView;
        }

        public void requestCountries()
        {
            getCountries.Execute(
                onNext: countries => { view.RenderCountries(countryModelMapper.Transform(countries)); },
                onError: error => view.ShowErrorMessage(error.Message),
                onCompleted: () => { }, parameters: null);
        }
    }
}