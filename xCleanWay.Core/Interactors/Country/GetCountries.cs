using System;
using System.Collections.ObjectModel;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.Country
{
    /// <summary>
    /// This use case is the responsible of retrieving country objects
    /// from data layer
    /// </summary>
    public class GetCountries : ObservableUseCase<Collection<Models.Country>, None>
    {
        private readonly ICountryRepository countryRepository;
        
        public GetCountries(IUiThread uiThread, IDataThread workerThread, 
            ICountryRepository countryRepository) : base(uiThread, workerThread)
        {
            this.countryRepository = countryRepository;
        }

        protected override IObservable<Collection<Models.Country>> BuildUseCaseObservable(None parameters)
        {
            return countryRepository.GetCountries();
        }
    }
}