using System;
using xCleanWay.Core.Repositories;
using xCleanWay.Core.Threading;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Interactors.Settings
{
    /// <summary>
    /// This use case is responsible of retrieving program's settings
    /// from data layer
    /// </summary>
    public class GetSettings : ObservableUseCase<Models.Settings, None>
    {
        private readonly ISettingsRepository settingsRepository;
        
        public GetSettings(IUiThread uiThread, IDataThread workerThread, 
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