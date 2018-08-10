namespace xCleanWay.Di.Factory
{
    public abstract class InjectorFactory
    {
        public static InjectorFactory Create(InjectorConfiguration config)
        {
            switch (config)
            {
                default:
                case InjectorConfiguration.FORMS_INJECTOR_CONFIG:
                    return new FormsInjectorFactory();
                    break;
            }
        }

        public abstract Injector build();
        
        public enum InjectorConfiguration
        {
            FORMS_INJECTOR_CONFIG
        }
    }
}