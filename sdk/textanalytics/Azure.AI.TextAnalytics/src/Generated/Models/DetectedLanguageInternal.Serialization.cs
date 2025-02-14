// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial struct DetectedLanguageInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            else
            {
                writer.WriteNull("name");
            }
            if (Iso6391Name != null)
            {
                writer.WritePropertyName("iso6391Name"u8);
                writer.WriteStringValue(Iso6391Name);
            }
            else
            {
                writer.WriteNull("iso6391Name");
            }
            writer.WritePropertyName("confidenceScore"u8);
            writer.WriteNumberValue(ConfidenceScore);
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DetectedLanguageInternal DeserializeDetectedLanguageInternal(JsonElement element)
        {
            string name = default;
            string iso6391Name = default;
            double confidenceScore = default;
            Optional<ScriptKind> script = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iso6391Name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        iso6391Name = null;
                        continue;
                    }
                    iso6391Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("script"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    script = new ScriptKind(property.Value.GetString());
                    continue;
                }
            }
            return new DetectedLanguageInternal(name, iso6391Name, confidenceScore, Optional.ToNullable(script));
        }
    }
}
