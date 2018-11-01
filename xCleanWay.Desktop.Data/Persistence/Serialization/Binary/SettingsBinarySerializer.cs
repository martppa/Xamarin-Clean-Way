/*
 * Copyright 2018 Humberto Martín Dieppa, Open source project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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