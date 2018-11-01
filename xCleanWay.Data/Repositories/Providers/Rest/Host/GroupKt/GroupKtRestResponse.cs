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