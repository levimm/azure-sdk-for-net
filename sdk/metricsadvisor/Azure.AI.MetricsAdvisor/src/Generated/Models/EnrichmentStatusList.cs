// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EnrichmentStatusList. </summary>
    internal partial class EnrichmentStatusList
    {
        /// <summary> Initializes a new instance of EnrichmentStatusList. </summary>
        internal EnrichmentStatusList()
        {
            Value = new ChangeTrackingList<EnrichmentStatus>();
        }

        /// <summary> Initializes a new instance of EnrichmentStatusList. </summary>
        /// <param name="nextLink"> . </param>
        /// <param name="value"> . </param>
        internal EnrichmentStatusList(string nextLink, IReadOnlyList<EnrichmentStatus> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        public IReadOnlyList<EnrichmentStatus> Value { get; }
    }
}