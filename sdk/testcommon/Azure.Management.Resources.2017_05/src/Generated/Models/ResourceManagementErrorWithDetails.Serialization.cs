// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class ResourceManagementErrorWithDetails
    {
        internal static ResourceManagementErrorWithDetails DeserializeResourceManagementErrorWithDetails(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<ResourceManagementErrorWithDetails>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    List<ResourceManagementErrorWithDetails> array = new List<ResourceManagementErrorWithDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeResourceManagementErrorWithDetails(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new ResourceManagementErrorWithDetails(code.Value, message.Value, target.Value, Optional.ToList(details));
        }
    }
}