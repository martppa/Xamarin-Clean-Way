using System;
using System.Collections.ObjectModel;
using xCleanWay.Core.Models;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.GetCountries
{
    public class GetCountries : ObservableUseCase<Collection<Country>, None>
    {
        private readonly ICountryRepository countryRepository;
        
        public GetCountries(IExecutionThread uiThread, IExecutionThread workerThread, 
            ICountryRepository countryRepository) : base(uiThread, workerThread)
        {
            this.countryRepository = countryRepository;
        }

        protected override IObservable<Collection<Country>> BuildUseCaseObservable(None parameters)
        {
            return countryRepository.GetCountries();
        }
    }
}