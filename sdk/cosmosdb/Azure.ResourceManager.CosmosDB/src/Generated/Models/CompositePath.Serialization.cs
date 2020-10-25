// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CompositePath : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order");
                writer.WriteStringValue(Order.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static CompositePath DeserializeCompositePath(JsonElement element)
        {
            Optional<string> path = default;
            Optional<CompositePathSortOrder> order = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    order = new CompositePathSortOrder(property.Value.GetString());
                    continue;
                }
            }
            return new CompositePath(path.Value, Optional.ToNullable(order));
        }
    }
}