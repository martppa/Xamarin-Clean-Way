using System;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.Settings
{
    public class SetCountryCacheLifeTime : CompletableUseCase<SetCountryCacheLifeTime.Params>
    {
        private readonly ISettingsRepository settingsRepository;

        public SetCountryCacheLifeTime(IExecutionThread uiThread, IExecutionThread workerThread, 
            ISettingsRepository settingsRepository) : base(uiThread, workerThread)
        {
            this.settingsRepository = settingsRepository;
        }

        protected override IObservable<None> BuildUseCaseObservable(Params parameters)
        {
            return settingsRepository.SetCacheLifeTimeInMillis(parameters.CountryCacheLifetime);
        }
        
        public class Params
        {
            private Params(long countryCacheLifetime)
            {
                this.CountryCacheLifetime = countryCacheLifetime;
            }

            public static Params ForValue(long countryCacheLifetime)
            {
                return new Params(countryCacheLifetime);
            }

            public long CountryCacheLifetime { get; }
        }
    }
}