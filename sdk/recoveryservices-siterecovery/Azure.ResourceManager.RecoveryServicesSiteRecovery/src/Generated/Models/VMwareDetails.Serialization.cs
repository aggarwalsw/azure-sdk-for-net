// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareDetails : IUtf8JsonSerializable, IJsonModel<VMwareDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(ProcessServers))
            {
                writer.WritePropertyName("processServers"u8);
                writer.WriteStartArray();
                foreach (var item in ProcessServers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MasterTargetServers))
            {
                writer.WritePropertyName("masterTargetServers"u8);
                writer.WriteStartArray();
                foreach (var item in MasterTargetServers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RunAsAccounts))
            {
                writer.WritePropertyName("runAsAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in RunAsAccounts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicationPairCount))
            {
                writer.WritePropertyName("replicationPairCount"u8);
                writer.WriteStringValue(ReplicationPairCount);
            }
            if (Optional.IsDefined(ProcessServerCount))
            {
                writer.WritePropertyName("processServerCount"u8);
                writer.WriteStringValue(ProcessServerCount);
            }
            if (Optional.IsDefined(AgentCount))
            {
                writer.WritePropertyName("agentCount"u8);
                writer.WriteStringValue(AgentCount);
            }
            if (Optional.IsDefined(ProtectedServers))
            {
                writer.WritePropertyName("protectedServers"u8);
                writer.WriteStringValue(ProtectedServers);
            }
            if (Optional.IsDefined(SystemLoad))
            {
                writer.WritePropertyName("systemLoad"u8);
                writer.WriteStringValue(SystemLoad);
            }
            if (Optional.IsDefined(SystemLoadStatus))
            {
                writer.WritePropertyName("systemLoadStatus"u8);
                writer.WriteStringValue(SystemLoadStatus);
            }
            if (Optional.IsDefined(CpuLoad))
            {
                writer.WritePropertyName("cpuLoad"u8);
                writer.WriteStringValue(CpuLoad);
            }
            if (Optional.IsDefined(CpuLoadStatus))
            {
                writer.WritePropertyName("cpuLoadStatus"u8);
                writer.WriteStringValue(CpuLoadStatus);
            }
            if (Optional.IsDefined(TotalMemoryInBytes))
            {
                writer.WritePropertyName("totalMemoryInBytes"u8);
                writer.WriteNumberValue(TotalMemoryInBytes.Value);
            }
            if (Optional.IsDefined(AvailableMemoryInBytes))
            {
                writer.WritePropertyName("availableMemoryInBytes"u8);
                writer.WriteNumberValue(AvailableMemoryInBytes.Value);
            }
            if (Optional.IsDefined(MemoryUsageStatus))
            {
                writer.WritePropertyName("memoryUsageStatus"u8);
                writer.WriteStringValue(MemoryUsageStatus);
            }
            if (Optional.IsDefined(TotalSpaceInBytes))
            {
                writer.WritePropertyName("totalSpaceInBytes"u8);
                writer.WriteNumberValue(TotalSpaceInBytes.Value);
            }
            if (Optional.IsDefined(AvailableSpaceInBytes))
            {
                writer.WritePropertyName("availableSpaceInBytes"u8);
                writer.WriteNumberValue(AvailableSpaceInBytes.Value);
            }
            if (Optional.IsDefined(SpaceUsageStatus))
            {
                writer.WritePropertyName("spaceUsageStatus"u8);
                writer.WriteStringValue(SpaceUsageStatus);
            }
            if (Optional.IsDefined(WebLoad))
            {
                writer.WritePropertyName("webLoad"u8);
                writer.WriteStringValue(WebLoad);
            }
            if (Optional.IsDefined(WebLoadStatus))
            {
                writer.WritePropertyName("webLoadStatus"u8);
                writer.WriteStringValue(WebLoadStatus);
            }
            if (Optional.IsDefined(DatabaseServerLoad))
            {
                writer.WritePropertyName("databaseServerLoad"u8);
                writer.WriteStringValue(DatabaseServerLoad);
            }
            if (Optional.IsDefined(DatabaseServerLoadStatus))
            {
                writer.WritePropertyName("databaseServerLoadStatus"u8);
                writer.WriteStringValue(DatabaseServerLoadStatus);
            }
            if (Optional.IsDefined(CsServiceStatus))
            {
                writer.WritePropertyName("csServiceStatus"u8);
                writer.WriteStringValue(CsServiceStatus);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(LastHeartbeat))
            {
                writer.WritePropertyName("lastHeartbeat"u8);
                writer.WriteStringValue(LastHeartbeat.Value, "O");
            }
            if (Optional.IsDefined(VersionStatus))
            {
                writer.WritePropertyName("versionStatus"u8);
                writer.WriteStringValue(VersionStatus);
            }
            if (Optional.IsDefined(SslCertExpireOn))
            {
                writer.WritePropertyName("sslCertExpiryDate"u8);
                writer.WriteStringValue(SslCertExpireOn.Value, "O");
            }
            if (Optional.IsDefined(SslCertExpiryRemainingDays))
            {
                writer.WritePropertyName("sslCertExpiryRemainingDays"u8);
                writer.WriteNumberValue(SslCertExpiryRemainingDays.Value);
            }
            if (Optional.IsDefined(PSTemplateVersion))
            {
                writer.WritePropertyName("psTemplateVersion"u8);
                writer.WriteStringValue(PSTemplateVersion);
            }
            if (Optional.IsDefined(AgentExpireOn))
            {
                writer.WritePropertyName("agentExpiryDate"u8);
                writer.WriteStringValue(AgentExpireOn.Value, "O");
            }
            if (Optional.IsDefined(AgentVersionDetails))
            {
                writer.WritePropertyName("agentVersionDetails"u8);
                writer.WriteObjectValue(AgentVersionDetails, options);
            }
            if (Optional.IsCollectionDefined(SwitchProviderBlockingErrorDetails))
            {
                writer.WritePropertyName("switchProviderBlockingErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in SwitchProviderBlockingErrorDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        VMwareDetails IJsonModel<VMwareDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareDetails(document.RootElement, options);
        }

        internal static VMwareDetails DeserializeVMwareDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SiteRecoveryProcessServer> processServers = default;
            IReadOnlyList<MasterTargetServer> masterTargetServers = default;
            IReadOnlyList<SiteRecoveryRunAsAccount> runAsAccounts = default;
            string replicationPairCount = default;
            string processServerCount = default;
            string agentCount = default;
            string protectedServers = default;
            string systemLoad = default;
            string systemLoadStatus = default;
            string cpuLoad = default;
            string cpuLoadStatus = default;
            long? totalMemoryInBytes = default;
            long? availableMemoryInBytes = default;
            string memoryUsageStatus = default;
            long? totalSpaceInBytes = default;
            long? availableSpaceInBytes = default;
            string spaceUsageStatus = default;
            string webLoad = default;
            string webLoadStatus = default;
            string databaseServerLoad = default;
            string databaseServerLoadStatus = default;
            string csServiceStatus = default;
            IPAddress ipAddress = default;
            string agentVersion = default;
            string hostName = default;
            DateTimeOffset? lastHeartbeat = default;
            string versionStatus = default;
            DateTimeOffset? sslCertExpireOn = default;
            int? sslCertExpiryRemainingDays = default;
            string psTemplateVersion = default;
            DateTimeOffset? agentExpireOn = default;
            SiteRecoveryVersionDetails agentVersionDetails = default;
            IReadOnlyList<InMageFabricSwitchProviderBlockingErrorDetails> switchProviderBlockingErrorDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryProcessServer> array = new List<SiteRecoveryProcessServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryProcessServer.DeserializeSiteRecoveryProcessServer(item, options));
                    }
                    processServers = array;
                    continue;
                }
                if (property.NameEquals("masterTargetServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MasterTargetServer> array = new List<MasterTargetServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MasterTargetServer.DeserializeMasterTargetServer(item, options));
                    }
                    masterTargetServers = array;
                    continue;
                }
                if (property.NameEquals("runAsAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryRunAsAccount> array = new List<SiteRecoveryRunAsAccount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryRunAsAccount.DeserializeSiteRecoveryRunAsAccount(item, options));
                    }
                    runAsAccounts = array;
                    continue;
                }
                if (property.NameEquals("replicationPairCount"u8))
                {
                    replicationPairCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerCount"u8))
                {
                    processServerCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentCount"u8))
                {
                    agentCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedServers"u8))
                {
                    protectedServers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoad"u8))
                {
                    systemLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoadStatus"u8))
                {
                    systemLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoad"u8))
                {
                    cpuLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoadStatus"u8))
                {
                    cpuLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableMemoryInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryUsageStatus"u8))
                {
                    memoryUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableSpaceInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spaceUsageStatus"u8))
                {
                    spaceUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webLoad"u8))
                {
                    webLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webLoadStatus"u8))
                {
                    webLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseServerLoad"u8))
                {
                    databaseServerLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseServerLoadStatus"u8))
                {
                    databaseServerLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("csServiceStatus"u8))
                {
                    csServiceStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslCertExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sslCertExpiryRemainingDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertExpiryRemainingDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("psTemplateVersion"u8))
                {
                    psTemplateVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("agentVersionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVersionDetails = SiteRecoveryVersionDetails.DeserializeSiteRecoveryVersionDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("switchProviderBlockingErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageFabricSwitchProviderBlockingErrorDetails> array = new List<InMageFabricSwitchProviderBlockingErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageFabricSwitchProviderBlockingErrorDetails.DeserializeInMageFabricSwitchProviderBlockingErrorDetails(item, options));
                    }
                    switchProviderBlockingErrorDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VMwareDetails(
                instanceType,
                serializedAdditionalRawData,
                processServers ?? new ChangeTrackingList<SiteRecoveryProcessServer>(),
                masterTargetServers ?? new ChangeTrackingList<MasterTargetServer>(),
                runAsAccounts ?? new ChangeTrackingList<SiteRecoveryRunAsAccount>(),
                replicationPairCount,
                processServerCount,
                agentCount,
                protectedServers,
                systemLoad,
                systemLoadStatus,
                cpuLoad,
                cpuLoadStatus,
                totalMemoryInBytes,
                availableMemoryInBytes,
                memoryUsageStatus,
                totalSpaceInBytes,
                availableSpaceInBytes,
                spaceUsageStatus,
                webLoad,
                webLoadStatus,
                databaseServerLoad,
                databaseServerLoadStatus,
                csServiceStatus,
                ipAddress,
                agentVersion,
                hostName,
                lastHeartbeat,
                versionStatus,
                sslCertExpireOn,
                sslCertExpiryRemainingDays,
                psTemplateVersion,
                agentExpireOn,
                agentVersionDetails,
                switchProviderBlockingErrorDetails ?? new ChangeTrackingList<InMageFabricSwitchProviderBlockingErrorDetails>());
        }

        BinaryData IPersistableModel<VMwareDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareDetails)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareDetails IPersistableModel<VMwareDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVMwareDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
