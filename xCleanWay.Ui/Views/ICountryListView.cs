using System.Collections.ObjectModel;
using xCleanWay.Ui.Models;

namespace xCleanWay.Ui.Views
{
    public interface ICountryListView : IView
    {
        void RenderCountries(Collection<CountryModel> countries);
    }
}