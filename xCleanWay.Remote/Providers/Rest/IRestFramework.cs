using System.Collections.Generic;

namespace xCleanWay.Remote.Providers.Rest
{
    public interface IRestFramework
    {
        T ExecuteGet<T>(string baseUrl, string route, Dictionary<string, string> parameters) where T : new();
    }
}