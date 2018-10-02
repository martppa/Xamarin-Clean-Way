using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using xCleanWay.Data.Repositories.Providers.Settings;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;

namespace xCleanWay.Desktop.Data.Persistence.Serialization.Binary
{
    /// <summary>
    /// Binary implementation of <see cref="ISettingsSerializer"/>
    /// </summary>
    public class SettingsBinarySerializer : ISettingsSerializer
    {
        private readonly string SETTINGS_FILENAME = "settings.bin";
        
        private IFormatter formatter;
        private FileStream settingsFileStream;

        public SettingsBinarySerializer()
        {
            formatter = new BinaryFormatter();
        }
        
        public RawSettings GetSettings()
        {
            settingsFileStream = new FileStream(SETTINGS_FILENAME, FileMode.Open, FileAccess.Read);
            var rawSettings = (RawSettings) formatter.Deserialize(settingsFileStream);
            settingsFileStream.Close();
            return rawSettings;
        }

        public void WriteSettings(RawSettings rawSettings)
        {
            settingsFileStream = new FileStream(SETTINGS_FILENAME, FileMode.CreateNew, FileAccess.Write);
            formatter.Serialize(settingsFileStream, rawSettings);
            settingsFileStream.Close();
        }
    }
}