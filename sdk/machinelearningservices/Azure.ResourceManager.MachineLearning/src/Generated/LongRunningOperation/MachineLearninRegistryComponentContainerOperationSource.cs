// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearninRegistryComponentContainerOperationSource : IOperationSource<MachineLearninRegistryComponentContainerResource>
    {
        private readonly ArmClient _client;

        internal MachineLearninRegistryComponentContainerOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearninRegistryComponentContainerResource IOperationSource<MachineLearninRegistryComponentContainerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MachineLearningComponentContainerData>(response.Content);
            return new MachineLearninRegistryComponentContainerResource(_client, data);
        }

        async ValueTask<MachineLearninRegistryComponentContainerResource> IOperationSource<MachineLearninRegistryComponentContainerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MachineLearningComponentContainerData>(response.Content);
            return await Task.FromResult(new MachineLearninRegistryComponentContainerResource(_client, data)).ConfigureAwait(false);
        }
    }
}
