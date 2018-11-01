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

using xCleanWay.Data.Repositories.Providers.Rest.Response;

namespace xCleanWay.Data.Repositories.Providers.Rest.Host.GroupKt
{
    /// <summary>
    ///     This class is intended to transform GroupKt host's response
    ///     into a standard readable response
    /// </summary>
    /// <typeparam name="Content">
    ///     Response's content type
    /// </typeparam>
    public class GroupKtResponseAdapter<Content> : IResponseAdapter<Content>
    {
        private readonly GroupKtRestResponse<Content> groupKtRestResponse;
        private string errorMessage;
        private ResponseStatus responseStatus;

        public GroupKtResponseAdapter(GroupKtRestResponse<Content> groupKtRestResponse)
        {
            this.groupKtRestResponse = groupKtRestResponse;
        }
        
        public GroupKtResponseAdapter(ResponseStatus responseStatus, string errorMessage)
        {
            this.errorMessage = errorMessage;
            this.responseStatus = responseStatus;
        }
        
        public ResponseStatus GetStatus()
        {
            return responseStatus;
        }

        public string GetErrorMessage()
        {
            return errorMessage;
        }

        public Content GetContent()
        {
            return groupKtRestResponse.Content;
        }
    }
}