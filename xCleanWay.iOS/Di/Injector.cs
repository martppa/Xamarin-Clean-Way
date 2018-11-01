/*
 * Copyright 2018 Humberto Martín Dieppa, Open source project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Microsoft.Extensions.DependencyInjection;
using xCleanWay.Data.Repositories.Cache;
using xCleanWay.Data.Repositories.Providers.Rest.Framework;
using xCleanWay.Data.Repositories.Providers.Settings.Serialization;
using xCleanWay.Di;
using xCleanWay.iOSData.Persistence.Cache.Country;
using xCleanWay.iOSData.Persistence.Settings;
using xCleanWay.Remote.RestSharp;

namespace xCleanWay.iOS.Di
{
    /// <summary>
    ///     iOS project's injector
    /// </summary>
    public class Injector : BusinessInjector
    {
        private static Injector instance;
        
        public static Injector GetInstance()
        {
            return instance ?? (instance = new Injector());
        }

        protected override void AddExtraServices()
        {
            serviceCollection.AddTransient<ICountryCache, CountryCustomCache>();
            serviceCollection.AddTransient<IRestFramework, RestSharpFramework>(); // <-- Replace the implementation to swap between different REST client framework
            serviceCollection.AddTransient<ISettingsSerializer, SettingsPreference>();
        }
    }
}