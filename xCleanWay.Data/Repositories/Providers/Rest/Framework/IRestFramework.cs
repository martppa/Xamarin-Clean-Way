using System.Collections.Generic;

namespace xCleanWay.Data.Repositories.Providers.Rest.Framework
{
    /// <summary>
    ///     IRestFramework must be implemented by a platform specific
    ///     class capable of providing the requested information
    /// </summary>
    public interface IRestFramework
    {
        T ExecuteGet<T>(string baseUrl, string route, Dictionary<string, string> parameters) where T : new();
    }
}