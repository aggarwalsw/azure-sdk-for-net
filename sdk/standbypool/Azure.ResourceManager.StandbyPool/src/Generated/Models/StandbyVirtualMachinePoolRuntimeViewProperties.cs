// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> Contains information about a standby pool as last known by the StandbyPool resource provider. </summary>
    public partial class StandbyVirtualMachinePoolRuntimeViewProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StandbyVirtualMachinePoolRuntimeViewProperties"/>. </summary>
        /// <param name="instanceCountSummary"> A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the StandbyPool resource provider. If zones are not enabled on the attached VMSS, the list will contain a single entry without zone values. Note: any resources in the Running state may still be installing extensions / not fully provisioned. </param>
        internal StandbyVirtualMachinePoolRuntimeViewProperties(IEnumerable<StandbyVirtualMachineInstanceCountSummary> instanceCountSummary)
        {
            InstanceCountSummary = instanceCountSummary.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="StandbyVirtualMachinePoolRuntimeViewProperties"/>. </summary>
        /// <param name="instanceCountSummary"> A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the StandbyPool resource provider. If zones are not enabled on the attached VMSS, the list will contain a single entry without zone values. Note: any resources in the Running state may still be installing extensions / not fully provisioned. </param>
        /// <param name="status"> Display status of the standby pool. </param>
        /// <param name="provisioningState"> Displays the provisioning state of the standby pool. </param>
        /// <param name="prediction"> Displays prediction information of the standby pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StandbyVirtualMachinePoolRuntimeViewProperties(IReadOnlyList<StandbyVirtualMachineInstanceCountSummary> instanceCountSummary, StandbyPoolStatus status, StandbyProvisioningState? provisioningState, StandbyVirtualMachinePoolPrediction prediction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceCountSummary = instanceCountSummary;
            Status = status;
            ProvisioningState = provisioningState;
            Prediction = prediction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StandbyVirtualMachinePoolRuntimeViewProperties"/> for deserialization. </summary>
        internal StandbyVirtualMachinePoolRuntimeViewProperties()
        {
        }

        /// <summary> A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the StandbyPool resource provider. If zones are not enabled on the attached VMSS, the list will contain a single entry without zone values. Note: any resources in the Running state may still be installing extensions / not fully provisioned. </summary>
        public IReadOnlyList<StandbyVirtualMachineInstanceCountSummary> InstanceCountSummary { get; }
        /// <summary> Display status of the standby pool. </summary>
        public StandbyPoolStatus Status { get; }
        /// <summary> Displays the provisioning state of the standby pool. </summary>
        public StandbyProvisioningState? ProvisioningState { get; }
        /// <summary> Displays prediction information of the standby pool. </summary>
        public StandbyVirtualMachinePoolPrediction Prediction { get; }
    }
}
