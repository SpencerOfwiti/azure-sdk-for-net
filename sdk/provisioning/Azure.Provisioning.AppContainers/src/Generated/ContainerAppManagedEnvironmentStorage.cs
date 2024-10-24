// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppManagedEnvironmentStorage.
/// </summary>
public partial class ContainerAppManagedEnvironmentStorage : ProvisionableResource
{
    /// <summary>
    /// Name of the storage.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Azure file properties.
    /// </summary>
    public BicepValue<ContainerAppAzureFileProperties> ManagedEnvironmentStorageAzureFile { get => _managedEnvironmentStorageAzureFile; set => _managedEnvironmentStorageAzureFile.Assign(value); }
    private readonly BicepValue<ContainerAppAzureFileProperties> _managedEnvironmentStorageAzureFile;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerAppManagedEnvironment.
    /// </summary>
    public ContainerAppManagedEnvironment? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerAppManagedEnvironment> _parent;

    /// <summary>
    /// Creates a new ContainerAppManagedEnvironmentStorage.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ContainerAppManagedEnvironmentStorage resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironmentStorage.</param>
    public ContainerAppManagedEnvironmentStorage(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.App/managedEnvironments/storages", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _managedEnvironmentStorageAzureFile = BicepValue<ContainerAppAzureFileProperties>.DefineProperty(this, "ManagedEnvironmentStorageAzureFile", ["properties", "azureFile"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerAppManagedEnvironment>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerAppManagedEnvironmentStorage resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2022-10-01.
        /// </summary>
        public static readonly string V2022_10_01 = "2022-10-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ContainerAppManagedEnvironmentStorage.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// ContainerAppManagedEnvironmentStorage resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedEnvironmentStorage.</param>
    /// <returns>The existing ContainerAppManagedEnvironmentStorage resource.</returns>
    public static ContainerAppManagedEnvironmentStorage FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
