// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    internal class DeviceProvisioningServiceOperationSource : IOperationSource<DeviceProvisioningServiceResource>
    {
        private readonly ArmClient _client;

        internal DeviceProvisioningServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        DeviceProvisioningServiceResource IOperationSource<DeviceProvisioningServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DeviceProvisioningServiceData>(response.Content);
            return new DeviceProvisioningServiceResource(_client, data);
        }

        async ValueTask<DeviceProvisioningServiceResource> IOperationSource<DeviceProvisioningServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DeviceProvisioningServiceData>(response.Content);
            return await Task.FromResult(new DeviceProvisioningServiceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
