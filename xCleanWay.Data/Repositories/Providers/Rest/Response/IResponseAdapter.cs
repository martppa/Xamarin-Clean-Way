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

namespace xCleanWay.Data.Repositories.Providers.Rest.Response
{
    /// <summary>
    ///     Response adapter interface. This class must be implemented
    ///     by a host specific adapters
    /// </summary>
    /// <typeparam name="Content">
    ///    Adapter's response content type
    /// </typeparam>
    public interface IResponseAdapter<out Content>
    {
        ResponseStatus GetStatus();
        string GetErrorMessage();
        Content GetContent();
    }

    public enum ResponseStatus
    {
        OK,
        ERROR
    }
}