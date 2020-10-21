// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PrivateLinkServiceVisibility
    {
        internal static PrivateLinkServiceVisibility DeserializePrivateLinkServiceVisibility(JsonElement element)
        {
            Optional<bool> visible = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("visible"))
                {
                    visible = property.Value.GetBoolean();
                    continue;
                }
            }
            return new PrivateLinkServiceVisibility(Optional.ToNullable(visible));
        }
    }
}