using System;
using xCleanWay.Data.Entities;

namespace xCleanWay.Data.Repositories.DataSources.Disk
{
    public interface ISettingsDataSource
    {
        IObservable<ISettingsEntity> GetSettings();
    }
}