// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// Operations for managing APIs.
    /// </summary>
    public partial interface IApisOperations
    {
        /// <summary>
        /// Creates new or updates existing specific API of the Api Management
        /// service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Identifier of the API.
        /// </param>
        /// <param name='parameters'>
        /// Create or update parameters.
        /// </param>
        /// <param name='etag'>
        /// ETag.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateOrUpdateAsync(string resourceGroupName, string serviceName, string aid, ApiCreateOrUpdateParameters parameters, string etag, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes specific API of the Api Management service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Identifier of the API.
        /// </param>
        /// <param name='etag'>
        /// ETag.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string serviceName, string aid, string etag, CancellationToken cancellationToken);
        
        /// <summary>
        /// Exporst API to one of the supported formats.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Identifier of the API.
        /// </param>
        /// <param name='accept'>
        /// Type of exporting content. Equivalent to Accept HTTP header.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the export API output operation.
        /// </returns>
        Task<ApiExportResponse> ExportAsync(string resourceGroupName, string serviceName, string aid, string accept, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets specific API of the Api Management service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Identifier of the API.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Get Api operation response details.
        /// </returns>
        Task<ApiGetResponse> GetAsync(string resourceGroupName, string serviceName, string aid, CancellationToken cancellationToken);
        
        /// <summary>
        /// Imports API from one of the supported formats.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Identifier of the API.
        /// </param>
        /// <param name='contentType'>
        /// Type of importing content.
        /// </param>
        /// <param name='content'>
        /// Importing content.
        /// </param>
        /// <param name='path'>
        /// Path in case importing document does not support path.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ImportAsync(string resourceGroupName, string serviceName, string aid, string contentType, Stream content, string path, CancellationToken cancellationToken);
        
        /// <summary>
        /// List all APIs of the Api Management service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List Api operations response details.
        /// </returns>
        Task<ApiListResponse> ListAsync(string resourceGroupName, string serviceName, QueryParameters query, CancellationToken cancellationToken);
        
        /// <summary>
        /// List all APIs of the Api Management service instance.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List Api operations response details.
        /// </returns>
        Task<ApiListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Patches specific API of the Api Management service instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='aid'>
        /// Identifier of the API.
        /// </param>
        /// <param name='parameters'>
        /// Patch parameters.
        /// </param>
        /// <param name='etag'>
        /// ETag.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> PatchAsync(string resourceGroupName, string serviceName, string aid, PatchParameters parameters, string etag, CancellationToken cancellationToken);
    }
}
