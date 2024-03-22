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

namespace Azure.ResourceManager.CosmosDB
{
    internal class ThroughputPoolAccountResourceOperationSource : IOperationSource<ThroughputPoolAccountResource>
    {
        private readonly ArmClient _client;

        internal ThroughputPoolAccountResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ThroughputPoolAccountResource IOperationSource<ThroughputPoolAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ThroughputPoolAccountResourceData.DeserializeThroughputPoolAccountResourceData(document.RootElement);
            return new ThroughputPoolAccountResource(_client, data);
        }

        async ValueTask<ThroughputPoolAccountResource> IOperationSource<ThroughputPoolAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ThroughputPoolAccountResourceData.DeserializeThroughputPoolAccountResourceData(document.RootElement);
            return new ThroughputPoolAccountResource(_client, data);
        }
    }
}
