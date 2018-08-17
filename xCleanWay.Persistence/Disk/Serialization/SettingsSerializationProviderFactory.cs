using xCleanWay.Persistence.Disk.Serialization.Binary.Factory;

namespace xCleanWay.Persistence.Disk.Serialization
{
    public abstract class SettingsSerializationProviderFactory
    {
        public SettingsSerializationProviderFactory Create(SerializationType serializationType)
        {
            switch (serializationType)
            {
                default:
                case SerializationType.BINARY:
                    return new SettingsBinarySerializationProviderFactory();
            }
        }

        public abstract ISettingsProvider Build();
    }
}