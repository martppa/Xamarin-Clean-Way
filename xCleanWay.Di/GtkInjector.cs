namespace xCleanWay.Di
{
    public class GtkInjector : BaseInjector
    {
        private const string CONFIG_PATH = "assembly://xCleanWay.Di/xCleanWay.Di.Configuration/GtkConfiguration.xml";
        
        public GtkInjector() : base(CONFIG_PATH) {}
    }
}