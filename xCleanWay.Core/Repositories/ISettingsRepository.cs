using System;
using xCleanWay.Core.Models;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Repositories
{
    /// <summary>
    /// Settings repository access interface to be implemented in the data layer
    /// </summary>
    public interface ISettingsRepository
    {
        IObservable<Settings> GetSettings();
        IObservable<None> SetCacheLifeTimeInMillis(long countryCacheLifetime);
    }
}