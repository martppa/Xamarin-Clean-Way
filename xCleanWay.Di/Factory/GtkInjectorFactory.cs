namespace xCleanWay.Di.Factory
{
    public class GtkInjectorFactory : InjectorFactory
    {
        public override Injector Build()
        {
            return new GtkInjector();
        }
    }
}