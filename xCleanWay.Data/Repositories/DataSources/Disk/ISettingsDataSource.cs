using System;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataSources.Disk
{
    /// <summary>
    /// Settings data store is intended for Settings retrieval
    /// </summary>
    public interface ISettingsDataSource
    {
        IObservable<ISettingsEntity> GetSettings();
    }
}