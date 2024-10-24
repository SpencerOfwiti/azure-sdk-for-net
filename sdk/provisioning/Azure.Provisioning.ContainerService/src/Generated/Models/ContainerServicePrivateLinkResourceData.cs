// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// A private link resource.
/// </summary>
public partial class ContainerServicePrivateLinkResourceData : ProvisionableConstruct
{
    /// <summary>
    /// The ID of the private link resource.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; set => _id.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The name of the private link resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The resource type.
    /// </summary>
    public BicepValue<ResourceType> ResourceType { get => _resourceType; set => _resourceType.Assign(value); }
    private readonly BicepValue<ResourceType> _resourceType;

    /// <summary>
    /// The group ID of the resource.
    /// </summary>
    public BicepValue<string> GroupId { get => _groupId; set => _groupId.Assign(value); }
    private readonly BicepValue<string> _groupId;

    /// <summary>
    /// The RequiredMembers of the resource.
    /// </summary>
    public BicepList<string> RequiredMembers { get => _requiredMembers; set => _requiredMembers.Assign(value); }
    private readonly BicepList<string> _requiredMembers;

    /// <summary>
    /// The private link service ID of the resource, this field is exposed only
    /// to NRP internally.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateLinkServiceId { get => _privateLinkServiceId; }
    private readonly BicepValue<ResourceIdentifier> _privateLinkServiceId;

    /// <summary>
    /// Creates a new ContainerServicePrivateLinkResourceData.
    /// </summary>
    public ContainerServicePrivateLinkResourceData()
    {
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"]);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _resourceType = BicepValue<ResourceType>.DefineProperty(this, "ResourceType", ["type"]);
        _groupId = BicepValue<string>.DefineProperty(this, "GroupId", ["groupId"]);
        _requiredMembers = BicepList<string>.DefineProperty(this, "RequiredMembers", ["requiredMembers"]);
        _privateLinkServiceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PrivateLinkServiceId", ["privateLinkServiceID"], isOutput: true);
    }
}
