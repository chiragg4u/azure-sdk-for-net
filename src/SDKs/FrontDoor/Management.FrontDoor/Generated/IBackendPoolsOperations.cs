// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BackendPoolsOperations operations.
    /// </summary>
    public partial interface IBackendPoolsOperations
    {
        /// <summary>
        /// Lists all of the Backend Pools within a Front Door.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='frontDoorName'>
        /// Name of the Front Door which is globally unique.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<BackendPool>>> ListByFrontDoorWithHttpMessagesAsync(string resourceGroupName, string frontDoorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a Backend Pool with the specified Pool name within the
        /// specified Front Door.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='frontDoorName'>
        /// Name of the Front Door which is globally unique.
        /// </param>
        /// <param name='backendPoolName'>
        /// Name of the Backend Pool which is unique within the Front Door.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BackendPool>> GetWithHttpMessagesAsync(string resourceGroupName, string frontDoorName, string backendPoolName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new Backend Pool with the specified Pool name within the
        /// specified Front Door.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='frontDoorName'>
        /// Name of the Front Door which is globally unique.
        /// </param>
        /// <param name='backendPoolName'>
        /// Name of the Backend Pool which is unique within the Front Door.
        /// </param>
        /// <param name='backendPoolParameters'>
        /// Backend Pool properties needed to create a new Pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BackendPool>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string frontDoorName, string backendPoolName, BackendPool backendPoolParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing Backend Pool with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='frontDoorName'>
        /// Name of the Front Door which is globally unique.
        /// </param>
        /// <param name='backendPoolName'>
        /// Name of the Backend Pool which is unique within the Front Door.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string frontDoorName, string backendPoolName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new Backend Pool with the specified Pool name within the
        /// specified Front Door.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='frontDoorName'>
        /// Name of the Front Door which is globally unique.
        /// </param>
        /// <param name='backendPoolName'>
        /// Name of the Backend Pool which is unique within the Front Door.
        /// </param>
        /// <param name='backendPoolParameters'>
        /// Backend Pool properties needed to create a new Pool.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<BackendPool>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string frontDoorName, string backendPoolName, BackendPool backendPoolParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing Backend Pool with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='frontDoorName'>
        /// Name of the Front Door which is globally unique.
        /// </param>
        /// <param name='backendPoolName'>
        /// Name of the Backend Pool which is unique within the Front Door.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string frontDoorName, string backendPoolName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the Backend Pools within a Front Door.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<BackendPool>>> ListByFrontDoorNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
