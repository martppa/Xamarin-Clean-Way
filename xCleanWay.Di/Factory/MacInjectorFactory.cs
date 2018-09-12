namespace xCleanWay.Di.Factory
{
    public class MacInjectorFactory : InjectorFactory
    {
        public override Injector Build()
        {
            return new MacInjector();
        }
    }
}