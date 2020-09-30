// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class IngestionStatusQueryOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime");
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime");
            writer.WriteStringValue(EndTime, "O");
            writer.WriteEndObject();
        }
    }
}