namespace xCleanWay.Di.Factory
{
    public class AndroidInjectorFactory : InjectorFactory
    {
        public override Injector Build()
        {
            return new AndroidInjector();
        }
    }
}