using System.Collections.Generic;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    public class GroupKtRestResponse<C>
    {
        public RestResponse<C> RestResponse { get; set; }
        public C Content => RestResponse.result;
    }
    
    public class RestResponse<C>
    {
        public List<string> messages { get; set; }
        public C result { get; set; }
    }
}