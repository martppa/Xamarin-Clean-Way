namespace xCleanWay.Di
{
    public class MacInjector : BaseInjector
    {
        private const string CONFIG_PATH = "assembly://xCleanWay.Di/xCleanWay.Di.Configuration/MacConfiguration.xml";
        
        public MacInjector() : base(CONFIG_PATH) {}
    }
}