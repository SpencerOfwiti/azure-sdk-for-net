// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ZoneMapping.
/// </summary>
public partial class ZoneMapping : ProvisionableConstruct
{
    /// <summary>
    /// Gets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets the Zones.
    /// </summary>
    public BicepList<string> Zones { get => _zones; }
    private readonly BicepList<string> _zones;

    /// <summary>
    /// Creates a new ZoneMapping.
    /// </summary>
    public ZoneMapping()
    {
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _zones = BicepList<string>.DefineProperty(this, "Zones", ["zones"], isOutput: true);
    }
}
