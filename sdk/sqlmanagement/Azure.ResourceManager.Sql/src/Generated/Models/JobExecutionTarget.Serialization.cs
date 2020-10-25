// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobExecutionTarget
    {
        internal static JobExecutionTarget DeserializeJobExecutionTarget(JsonElement element)
        {
            Optional<JobTargetType> type = default;
            Optional<string> serverName = default;
            Optional<string> databaseName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new JobTargetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverName"))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
            }
            return new JobExecutionTarget(Optional.ToNullable(type), serverName.Value, databaseName.Value);
        }
    }
}