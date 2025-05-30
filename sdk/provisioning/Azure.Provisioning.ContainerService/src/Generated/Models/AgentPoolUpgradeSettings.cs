// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Settings for upgrading an agentpool.
/// </summary>
public partial class AgentPoolUpgradeSettings : ProvisionableConstruct
{
    /// <summary>
    /// This can either be set to an integer (e.g. &apos;5&apos;) or a
    /// percentage (e.g. &apos;50%&apos;). If a percentage is specified, it is
    /// the percentage of the total agent pool size at the time of the
    /// upgrade. For percentages, fractional nodes are rounded up. If not
    /// specified, the default is 1. For more information, including best
    /// practices, see:
    /// https://docs.microsoft.com/azure/aks/upgrade-cluster#customize-node-surge-upgrade.
    /// </summary>
    public BicepValue<string> MaxSurge 
    {
        get { Initialize(); return _maxSurge!; }
        set { Initialize(); _maxSurge!.Assign(value); }
    }
    private BicepValue<string>? _maxSurge;

    /// <summary>
    /// The amount of time (in minutes) to wait on eviction of pods and
    /// graceful termination per node. This eviction wait time honors waiting
    /// on pod disruption budgets. If this time is exceeded, the upgrade
    /// fails. If not specified, the default is 30 minutes.
    /// </summary>
    public BicepValue<int> DrainTimeoutInMinutes 
    {
        get { Initialize(); return _drainTimeoutInMinutes!; }
        set { Initialize(); _drainTimeoutInMinutes!.Assign(value); }
    }
    private BicepValue<int>? _drainTimeoutInMinutes;

    /// <summary>
    /// Creates a new AgentPoolUpgradeSettings.
    /// </summary>
    public AgentPoolUpgradeSettings()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AgentPoolUpgradeSettings.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _maxSurge = DefineProperty<string>("MaxSurge", ["maxSurge"]);
        _drainTimeoutInMinutes = DefineProperty<int>("DrainTimeoutInMinutes", ["drainTimeoutInMinutes"]);
    }
}
