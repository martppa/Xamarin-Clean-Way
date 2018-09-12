using System;
using System.Reactive;
using xCleanWay.Persistence.RawModels;

namespace xCleanWay.Persistence.Disk.Serialization
{
    public interface ISettingsSerializer
    {
        RawSettings GetSettings();
        void WriteSettings(RawSettings rawSettings);
    }
}