// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityVmInfo : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityVmInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityVmInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NewRelicObservabilityVmInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityVmInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AgentStatus))
            {
                writer.WritePropertyName("agentStatus"u8);
                writer.WriteStringValue(AgentStatus);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        NewRelicObservabilityVmInfo IJsonModel<NewRelicObservabilityVmInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityVmInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityVmInfo(document.RootElement, options);
        }

        internal static NewRelicObservabilityVmInfo DeserializeNewRelicObservabilityVmInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmId = default;
            string agentVersion = default;
            string agentStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentStatus"u8))
                {
                    agentStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NewRelicObservabilityVmInfo(vmId, agentVersion, agentStatus, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  vmId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmId))
                {
                    builder.Append("  vmId: ");
                    builder.AppendLine($"'{VmId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgentVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  agentVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgentVersion))
                {
                    builder.Append("  agentVersion: ");
                    if (AgentVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgentVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgentVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgentStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  agentStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgentStatus))
                {
                    builder.Append("  agentStatus: ");
                    if (AgentStatus.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgentStatus}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgentStatus}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NewRelicObservabilityVmInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityVmInfo)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicObservabilityVmInfo IPersistableModel<NewRelicObservabilityVmInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityVmInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNewRelicObservabilityVmInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityVmInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicObservabilityVmInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
