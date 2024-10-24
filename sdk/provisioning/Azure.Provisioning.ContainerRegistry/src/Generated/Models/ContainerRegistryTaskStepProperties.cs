// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// Base properties for any task step.             Please note
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTaskStepProperties
/// is the base class. According to the scenario, a derived class of the base
/// class might need to be assigned here, or this property needs to be casted
/// to one of the possible derived classes.             The available derived
/// classes include
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryDockerBuildStep,
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncodedTaskStep
/// and
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryFileTaskStep.
/// </summary>
public partial class ContainerRegistryTaskStepProperties : ProvisionableConstruct
{
    /// <summary>
    /// List of base image dependencies for a step.
    /// </summary>
    public BicepList<ContainerRegistryBaseImageDependency> BaseImageDependencies { get => _baseImageDependencies; }
    private readonly BicepList<ContainerRegistryBaseImageDependency> _baseImageDependencies;

    /// <summary>
    /// The URL(absolute or relative) of the source context for the task step.
    /// </summary>
    public BicepValue<string> ContextPath { get => _contextPath; set => _contextPath.Assign(value); }
    private readonly BicepValue<string> _contextPath;

    /// <summary>
    /// The token (git PAT or SAS token of storage account blob) associated
    /// with the context for a step.
    /// </summary>
    public BicepValue<string> ContextAccessToken { get => _contextAccessToken; set => _contextAccessToken.Assign(value); }
    private readonly BicepValue<string> _contextAccessToken;

    /// <summary>
    /// Creates a new ContainerRegistryTaskStepProperties.
    /// </summary>
    public ContainerRegistryTaskStepProperties()
    {
        _baseImageDependencies = BicepList<ContainerRegistryBaseImageDependency>.DefineProperty(this, "BaseImageDependencies", ["baseImageDependencies"], isOutput: true);
        _contextPath = BicepValue<string>.DefineProperty(this, "ContextPath", ["contextPath"]);
        _contextAccessToken = BicepValue<string>.DefineProperty(this, "ContextAccessToken", ["contextAccessToken"]);
    }
}
