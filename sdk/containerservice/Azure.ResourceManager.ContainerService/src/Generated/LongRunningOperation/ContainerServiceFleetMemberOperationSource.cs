// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerService
{
    internal class ContainerServiceFleetMemberOperationSource : IOperationSource<ContainerServiceFleetMemberResource>
    {
        private readonly ArmClient _client;

        internal ContainerServiceFleetMemberOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerServiceFleetMemberResource IOperationSource<ContainerServiceFleetMemberResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ContainerServiceFleetMemberData.DeserializeContainerServiceFleetMemberData(document.RootElement);
            return new ContainerServiceFleetMemberResource(_client, data);
        }

        async ValueTask<ContainerServiceFleetMemberResource> IOperationSource<ContainerServiceFleetMemberResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ContainerServiceFleetMemberData.DeserializeContainerServiceFleetMemberData(document.RootElement);
            return new ContainerServiceFleetMemberResource(_client, data);
        }
    }
}
