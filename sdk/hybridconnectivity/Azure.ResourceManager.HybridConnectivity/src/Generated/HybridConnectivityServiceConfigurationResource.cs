// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridConnectivity.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary>
    /// A Class representing a HybridConnectivityServiceConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HybridConnectivityServiceConfigurationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHybridConnectivityServiceConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="HybridConnectivityEndpointResource"/> using the GetHybridConnectivityServiceConfiguration method.
    /// </summary>
    public partial class HybridConnectivityServiceConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HybridConnectivityServiceConfigurationResource"/> instance. </summary>
        /// <param name="resourceUri"> The resourceUri. </param>
        /// <param name="endpointName"> The endpointName. </param>
        /// <param name="serviceConfigurationName"> The serviceConfigurationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string endpointName, string serviceConfigurationName)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics;
        private readonly ServiceConfigurationResourcesRestOperations _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient;
        private readonly HybridConnectivityServiceConfigurationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridConnectivity/endpoints/serviceConfigurations";

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivityServiceConfigurationResource"/> class for mocking. </summary>
        protected HybridConnectivityServiceConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivityServiceConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HybridConnectivityServiceConfigurationResource(ArmClient client, HybridConnectivityServiceConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivityServiceConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HybridConnectivityServiceConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridConnectivity", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hybridConnectivityServiceConfigurationServiceConfigurationResourcesApiVersion);
            _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient = new ServiceConfigurationResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridConnectivityServiceConfigurationServiceConfigurationResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridConnectivityServiceConfigurationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details about the service to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HybridConnectivityServiceConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics.CreateScope("HybridConnectivityServiceConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivityServiceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details about the service to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HybridConnectivityServiceConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics.CreateScope("HybridConnectivityServiceConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivityServiceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the service details to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurationResource_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics.CreateScope("HybridConnectivityServiceConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = await _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.DeleteAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.CreateDeleteRequestUri(Id.Parent.Parent, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HybridConnectivityArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the service details to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurationResource_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics.CreateScope("HybridConnectivityServiceConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.Delete(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.CreateDeleteRequestUri(Id.Parent.Parent, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HybridConnectivityArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the service details in the service configurations of the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurationResource_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Service details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<HybridConnectivityServiceConfigurationResource>> UpdateAsync(HybridConnectivityServiceConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics.CreateScope("HybridConnectivityServiceConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = await _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.UpdateAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new HybridConnectivityServiceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the service details in the service configurations of the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurationResource_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Service details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<HybridConnectivityServiceConfigurationResource> Update(HybridConnectivityServiceConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesClientDiagnostics.CreateScope("HybridConnectivityServiceConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = _hybridConnectivityServiceConfigurationServiceConfigurationResourcesRestClient.Update(Id.Parent.Parent, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new HybridConnectivityServiceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
