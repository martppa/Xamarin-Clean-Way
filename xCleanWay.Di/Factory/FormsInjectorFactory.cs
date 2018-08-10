namespace xCleanWay.Di.Factory
{
    public class FormsInjectorFactory : InjectorFactory
    {
        public override Injector build()
        {
            return new FormsInjector();
        }
    }
}