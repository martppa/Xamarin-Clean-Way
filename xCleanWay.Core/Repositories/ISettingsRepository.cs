using System;
using xCleanWay.Core.Models;
using xCleanWay.Core.Utils;

namespace xCleanWay.Core.Repositories
{
    public interface ISettingsRepository
    {
        IObservable<Settings> GetSettings();
        IObservable<None> SetCacheLifeTimeInMillis(long countryCacheLifetime);
    }
}