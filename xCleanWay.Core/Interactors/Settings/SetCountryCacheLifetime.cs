using System;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.Settings
{
    /// <summary>
    /// This use case is responsible of setting a specific cache life time
    /// for countries stored in local disk
    /// </summary>
    public class SetCountryCacheLifeTime : CompletableUseCase<SetCountryCacheLifeTime.Params>
    {
        private readonly ISettingsRepository settingsRepository;

        public SetCountryCacheLifeTime(IUiThread uiThread, IDataThread workerThread, 
            ISettingsRepository settingsRepository) : base(uiThread, workerThread)
        {
            this.settingsRepository = settingsRepository;
        }

        protected override IObservable<None> BuildUseCaseObservable(Params parameters)
        {
            return settingsRepository.SetCacheLifeTimeInMillis(parameters.CountryCacheLifetime);
        }
        
        /// <summary>
        /// Params class is intended to hold parameters passed to the
        /// use case, as in this case it will deal with the cache lifetime
        /// with will be stored in disk.
        /// </summary>
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