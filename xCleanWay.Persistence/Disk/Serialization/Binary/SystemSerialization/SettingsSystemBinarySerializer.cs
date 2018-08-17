using System.Runtime.Serialization;
using xCleanWay.Persistence.RawModels;

namespace xCleanWay.Persistence.Disk.Serialization.Binary.SystemSerialization
{
    public class SettingsSystemBinarySerializer : ISettingsSerializer
    {
        private IFormatter binaryFormatter;
        
        public RawSettings GetSettings()
        {
            throw new System.NotImplementedException();
        }

        public void WriteSettings(RawSettings rawSettings)
        {
            throw new System.NotImplementedException();
        }
    }
}