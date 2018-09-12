namespace xCleanWay.Di.Factory
{
    public abstract class InjectorFactory
    {
        public static InjectorFactory Create(InjectorConfiguration config)
        {
            switch (config)
            {
                default:
                case InjectorConfiguration.GTK_INJECTOR_CONFIG:
                    return new GtkInjectorFactory();
            }
        }

        public abstract Injector Build();
        
        public enum InjectorConfiguration
        {
            GTK_INJECTOR_CONFIG,
            MAC_INJECTOR_CONFIG,
            ANDROID_INJECTOR_CONFIG,
        }
    }
}