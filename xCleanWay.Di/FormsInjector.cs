namespace xCleanWay.Di
{
    public class FormsInjector : BaseInjector
    {
        private const string CONFIG_PATH = "assembly://Di/xCleanWay.Di.Configuration/FormsConfiguration.xml";
        
        public FormsInjector() 
            : base(CONFIG_PATH)
        {
            // Empty
        }
    }
}