namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    public class GroupKtRestResponse<C>
    {
        private string[] messages;
        private C result;

        private string errorMessage;

        public C Content => result;

        public string ErrorMessage => errorMessage;
    }
}