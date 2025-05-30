// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Resource extended location.
/// </summary>
public partial class ExtendedAzureLocation : ProvisionableConstruct
{
    /// <summary>
    /// The extended location type.
    /// </summary>
    public BicepValue<ExtendedLocationType> ExtendedLocationType 
    {
        get { Initialize(); return _extendedLocationType!; }
        set { Initialize(); _extendedLocationType!.Assign(value); }
    }
    private BicepValue<ExtendedLocationType>? _extendedLocationType;

    /// <summary>
    /// The extended location name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Creates a new ExtendedAzureLocation.
    /// </summary>
    public ExtendedAzureLocation()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ExtendedAzureLocation.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _extendedLocationType = DefineProperty<ExtendedLocationType>("ExtendedLocationType", ["type"]);
        _name = DefineProperty<string>("Name", ["name"]);
    }
}
