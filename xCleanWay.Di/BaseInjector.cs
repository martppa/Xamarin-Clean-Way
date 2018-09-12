using Spring.Context;
using Spring.Context.Support;

namespace xCleanWay.Di
{
    public abstract class BaseInjector : Injector
    {
        protected IApplicationContext applicationContext;

        protected BaseInjector(string injectorConfigPath)
        {
            applicationContext = CreateApplicationContext(injectorConfigPath);
        }

        private IApplicationContext CreateApplicationContext(string injectorConfigPath)
        {
            return new XmlApplicationContext(injectorConfigPath);
        }

        public void Inject<T>(out T t)
        {
            t = applicationContext.GetObject<T>();
        }
    }
}