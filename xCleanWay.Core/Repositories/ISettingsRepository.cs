using System;
using xCleanWay.Core.Models;

namespace xCleanWay.Core.Repositories
{
    public interface ISettingsRepository
    {
        IObservable<Settings> GetSettings();
        IObservable<object> SetCacheLifeTimeInMillis();
    }
}