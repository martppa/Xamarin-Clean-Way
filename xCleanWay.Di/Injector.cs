namespace xCleanWay.Di
{
    public interface Injector
    {
        void Inject<T>(out T t);
    }
}