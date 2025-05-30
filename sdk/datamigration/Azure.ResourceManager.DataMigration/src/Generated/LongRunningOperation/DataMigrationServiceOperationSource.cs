// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration
{
    internal class DataMigrationServiceOperationSource : IOperationSource<DataMigrationServiceResource>
    {
        private readonly ArmClient _client;

        internal DataMigrationServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataMigrationServiceResource IOperationSource<DataMigrationServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataMigrationServiceData>(response.Content);
            return new DataMigrationServiceResource(_client, data);
        }

        async ValueTask<DataMigrationServiceResource> IOperationSource<DataMigrationServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataMigrationServiceData>(response.Content);
            return await Task.FromResult(new DataMigrationServiceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
