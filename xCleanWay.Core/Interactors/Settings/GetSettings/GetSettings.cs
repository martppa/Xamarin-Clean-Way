using System;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.Settings.GetSettings
{
    public class GetSettings : ObservableUseCase<Models.Settings, None>
    {
        private readonly ISettingsRepository settingsRepository;
        
        public GetSettings(IExecutionThread uiThread, IExecutionThread workerThread, 
            ISettingsRepository settingsRepository) : base(uiThread, workerThread)
        {
            this.settingsRepository = settingsRepository;
        }

        protected override IObservable<Models.Settings> BuildUseCaseObservable(None parameters)
        {
            return settingsRepository.GetSettings();
        }
    }
}