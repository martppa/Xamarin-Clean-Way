using System.Collections.Generic;

namespace xCleanWay.Data.Repositories.Providers.Rest.Framework
{
    public interface IRestFramework
    {
        T ExecuteGet<T>(string baseUrl, string route, Dictionary<string, string> parameters) where T : new();
    }
}