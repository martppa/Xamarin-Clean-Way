namespace xCleanWay.Di
{
    public class AndroidInjector : BaseInjector
    {
        private const string CONFIG_PATH = "assembly://xCleanWay.Di/xCleanWay.Di.Configuration/AndroidConfiguration.xml";
        
        public AndroidInjector() : base(CONFIG_PATH) {}
    }
}