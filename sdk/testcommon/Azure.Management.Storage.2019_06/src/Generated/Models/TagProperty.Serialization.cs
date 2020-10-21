// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class TagProperty
    {
        internal static TagProperty DeserializeTagProperty(JsonElement element)
        {
            Optional<string> tag = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> objectIdentifier = default;
            Optional<string> tenantId = default;
            Optional<string> upn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tag"))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectIdentifier"))
                {
                    objectIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upn"))
                {
                    upn = property.Value.GetString();
                    continue;
                }
            }
            return new TagProperty(tag.Value, Optional.ToNullable(timestamp), objectIdentifier.Value, tenantId.Value, upn.Value);
        }
    }
}