// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Strictly used in update requests. </summary>
    public partial class PartialBatchEndpointPartialTrackedResource
    {
        /// <summary> Initializes a new instance of PartialBatchEndpointPartialTrackedResource. </summary>
        public PartialBatchEndpointPartialTrackedResource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Service identity associated with a resource. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </summary>
        public string Kind { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; set; }
        /// <summary> Additional attributes of the entity. </summary>
        public PartialBatchEndpoint Properties { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
