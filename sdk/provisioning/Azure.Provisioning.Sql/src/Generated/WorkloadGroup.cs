// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// WorkloadGroup.
/// </summary>
public partial class WorkloadGroup : ProvisionableResource
{
    /// <summary>
    /// The name of the workload group.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The workload group importance level.
    /// </summary>
    public BicepValue<string> Importance { get => _importance; set => _importance.Assign(value); }
    private readonly BicepValue<string> _importance;

    /// <summary>
    /// The workload group cap percentage resource.
    /// </summary>
    public BicepValue<int> MaxResourcePercent { get => _maxResourcePercent; set => _maxResourcePercent.Assign(value); }
    private readonly BicepValue<int> _maxResourcePercent;

    /// <summary>
    /// The workload group request maximum grant percentage.
    /// </summary>
    public BicepValue<double> MaxResourcePercentPerRequest { get => _maxResourcePercentPerRequest; set => _maxResourcePercentPerRequest.Assign(value); }
    private readonly BicepValue<double> _maxResourcePercentPerRequest;

    /// <summary>
    /// The workload group minimum percentage resource.
    /// </summary>
    public BicepValue<int> MinResourcePercent { get => _minResourcePercent; set => _minResourcePercent.Assign(value); }
    private readonly BicepValue<int> _minResourcePercent;

    /// <summary>
    /// The workload group request minimum grant percentage.
    /// </summary>
    public BicepValue<double> MinResourcePercentPerRequest { get => _minResourcePercentPerRequest; set => _minResourcePercentPerRequest.Assign(value); }
    private readonly BicepValue<double> _minResourcePercentPerRequest;

    /// <summary>
    /// The workload group query execution timeout.
    /// </summary>
    public BicepValue<int> QueryExecutionTimeout { get => _queryExecutionTimeout; set => _queryExecutionTimeout.Assign(value); }
    private readonly BicepValue<int> _queryExecutionTimeout;

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
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlDatabase> _parent;

    /// <summary>
    /// Creates a new WorkloadGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadGroup.</param>
    public WorkloadGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/workloadGroups", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _importance = BicepValue<string>.DefineProperty(this, "Importance", ["properties", "importance"]);
        _maxResourcePercent = BicepValue<int>.DefineProperty(this, "MaxResourcePercent", ["properties", "maxResourcePercent"]);
        _maxResourcePercentPerRequest = BicepValue<double>.DefineProperty(this, "MaxResourcePercentPerRequest", ["properties", "maxResourcePercentPerRequest"]);
        _minResourcePercent = BicepValue<int>.DefineProperty(this, "MinResourcePercent", ["properties", "minResourcePercent"]);
        _minResourcePercentPerRequest = BicepValue<double>.DefineProperty(this, "MinResourcePercentPerRequest", ["properties", "minResourcePercentPerRequest"]);
        _queryExecutionTimeout = BicepValue<int>.DefineProperty(this, "QueryExecutionTimeout", ["properties", "queryExecutionTimeout"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WorkloadGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing WorkloadGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadGroup.</param>
    /// <returns>The existing WorkloadGroup resource.</returns>
    public static WorkloadGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
