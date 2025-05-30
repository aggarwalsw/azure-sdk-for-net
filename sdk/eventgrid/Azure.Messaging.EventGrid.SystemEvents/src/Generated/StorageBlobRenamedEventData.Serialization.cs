// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class StorageBlobRenamedEventData : IUtf8JsonSerializable, IJsonModel<StorageBlobRenamedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageBlobRenamedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageBlobRenamedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobRenamedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageBlobRenamedEventData)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Api))
            {
                writer.WritePropertyName("api"u8);
                writer.WriteStringValue(Api);
            }
            if (Optional.IsDefined(ClientRequestId))
            {
                writer.WritePropertyName("clientRequestId"u8);
                writer.WriteStringValue(ClientRequestId);
            }
            if (Optional.IsDefined(RequestId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (Optional.IsDefined(SourceUrl))
            {
                writer.WritePropertyName("sourceUrl"u8);
                writer.WriteStringValue(SourceUrl);
            }
            if (Optional.IsDefined(DestinationUrl))
            {
                writer.WritePropertyName("destinationUrl"u8);
                writer.WriteStringValue(DestinationUrl);
            }
            if (Optional.IsDefined(Sequencer))
            {
                writer.WritePropertyName("sequencer"u8);
                writer.WriteStringValue(Sequencer);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteStringValue(Identity);
            }
            writer.WritePropertyName("storageDiagnostics"u8);
            writer.WriteStartObject();
            foreach (var item in StorageDiagnostics)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
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

        StorageBlobRenamedEventData IJsonModel<StorageBlobRenamedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobRenamedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageBlobRenamedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageBlobRenamedEventData(document.RootElement, options);
        }

        internal static StorageBlobRenamedEventData DeserializeStorageBlobRenamedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string api = default;
            string clientRequestId = default;
            string requestId = default;
            string sourceUrl = default;
            string destinationUrl = default;
            string sequencer = default;
            string identity = default;
            IReadOnlyDictionary<string, BinaryData> storageDiagnostics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"u8))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceUrl"u8))
                {
                    sourceUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationUrl"u8))
                {
                    destinationUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"u8))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    storageDiagnostics = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageBlobRenamedEventData(
                api,
                clientRequestId,
                requestId,
                sourceUrl,
                destinationUrl,
                sequencer,
                identity,
                storageDiagnostics,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageBlobRenamedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobRenamedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageBlobRenamedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        StorageBlobRenamedEventData IPersistableModel<StorageBlobRenamedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobRenamedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageBlobRenamedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageBlobRenamedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageBlobRenamedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StorageBlobRenamedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeStorageBlobRenamedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
