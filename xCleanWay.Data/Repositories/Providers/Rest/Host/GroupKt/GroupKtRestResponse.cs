using System.Collections.Generic;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    /// <summary>
    ///     Groupkt host's answer schema according to its json
    /// </summary>
    /// <typeparam name="C">
    ///     Response content type
    /// </typeparam>
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