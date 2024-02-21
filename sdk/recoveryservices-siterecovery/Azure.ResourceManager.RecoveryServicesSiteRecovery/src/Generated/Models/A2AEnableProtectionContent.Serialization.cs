// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AEnableProtectionContent : IUtf8JsonSerializable, IJsonModel<A2AEnableProtectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AEnableProtectionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AEnableProtectionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AEnableProtectionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fabricObjectId"u8);
            writer.WriteStringValue(FabricObjectId);
            if (Optional.IsDefined(RecoveryContainerId))
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (Optional.IsDefined(RecoveryCloudServiceId))
            {
                writer.WritePropertyName("recoveryCloudServiceId"u8);
                writer.WriteStringValue(RecoveryCloudServiceId);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(RecoveryProximityPlacementGroupId))
            {
                writer.WritePropertyName("recoveryProximityPlacementGroupId"u8);
                writer.WriteStringValue(RecoveryProximityPlacementGroupId);
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmManagedDisks))
            {
                writer.WritePropertyName("vmManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmManagedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (Optional.IsDefined(MultiVmGroupId))
            {
                writer.WritePropertyName("multiVmGroupId"u8);
                writer.WriteStringValue(MultiVmGroupId);
            }
            if (Optional.IsDefined(RecoveryBootDiagStorageAccountId))
            {
                writer.WritePropertyName("recoveryBootDiagStorageAccountId"u8);
                writer.WriteStringValue(RecoveryBootDiagStorageAccountId);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
            }
            if (Optional.IsDefined(RecoveryAvailabilityZone))
            {
                writer.WritePropertyName("recoveryAvailabilityZone"u8);
                writer.WriteStringValue(RecoveryAvailabilityZone);
            }
            if (Optional.IsDefined(RecoveryExtendedLocation))
            {
                writer.WritePropertyName("recoveryExtendedLocation"u8);
                writer.WriteObjectValue(RecoveryExtendedLocation);
            }
            if (Optional.IsDefined(RecoveryAzureNetworkId))
            {
                writer.WritePropertyName("recoveryAzureNetworkId"u8);
                writer.WriteStringValue(RecoveryAzureNetworkId);
            }
            if (Optional.IsDefined(RecoverySubnetName))
            {
                writer.WritePropertyName("recoverySubnetName"u8);
                writer.WriteStringValue(RecoverySubnetName);
            }
            if (Optional.IsDefined(RecoveryVirtualMachineScaleSetId))
            {
                writer.WritePropertyName("recoveryVirtualMachineScaleSetId"u8);
                writer.WriteStringValue(RecoveryVirtualMachineScaleSetId);
            }
            if (Optional.IsDefined(RecoveryCapacityReservationGroupId))
            {
                writer.WritePropertyName("recoveryCapacityReservationGroupId"u8);
                writer.WriteStringValue(RecoveryCapacityReservationGroupId);
            }
            if (Optional.IsDefined(AutoProtectionOfDataDisk))
            {
                writer.WritePropertyName("autoProtectionOfDataDisk"u8);
                writer.WriteStringValue(AutoProtectionOfDataDisk.Value.ToString());
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        A2AEnableProtectionContent IJsonModel<A2AEnableProtectionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AEnableProtectionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AEnableProtectionContent(document.RootElement, options);
        }

        internal static A2AEnableProtectionContent DeserializeA2AEnableProtectionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier fabricObjectId = default;
            Optional<ResourceIdentifier> recoveryContainerId = default;
            Optional<ResourceIdentifier> recoveryResourceGroupId = default;
            Optional<string> recoveryCloudServiceId = default;
            Optional<ResourceIdentifier> recoveryAvailabilitySetId = default;
            Optional<ResourceIdentifier> recoveryProximityPlacementGroupId = default;
            Optional<IList<A2AVmDiskDetails>> vmDisks = default;
            Optional<IList<A2AVmManagedDiskDetails>> vmManagedDisks = default;
            Optional<string> multiVmGroupName = default;
            Optional<string> multiVmGroupId = default;
            Optional<ResourceIdentifier> recoveryBootDiagStorageAccountId = default;
            Optional<SiteRecoveryDiskEncryptionInfo> diskEncryptionInfo = default;
            Optional<string> recoveryAvailabilityZone = default;
            Optional<SiteRecoveryExtendedLocation> recoveryExtendedLocation = default;
            Optional<ResourceIdentifier> recoveryAzureNetworkId = default;
            Optional<string> recoverySubnetName = default;
            Optional<ResourceIdentifier> recoveryVirtualMachineScaleSetId = default;
            Optional<ResourceIdentifier> recoveryCapacityReservationGroupId = default;
            Optional<AutoProtectionOfDataDisk> autoProtectionOfDataDisk = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricObjectId"u8))
                {
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryCloudServiceId"u8))
                {
                    recoveryCloudServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AVmDiskDetails> array = new List<A2AVmDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AVmDiskDetails.DeserializeA2AVmDiskDetails(item));
                    }
                    vmDisks = array;
                    continue;
                }
                if (property.NameEquals("vmManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AVmManagedDiskDetails> array = new List<A2AVmManagedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AVmManagedDiskDetails.DeserializeA2AVmManagedDiskDetails(item));
                    }
                    vmManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupId"u8))
                {
                    multiVmGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryBootDiagStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryBootDiagStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionInfo = SiteRecoveryDiskEncryptionInfo.DeserializeSiteRecoveryDiskEncryptionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilityZone"u8))
                {
                    recoveryAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoverySubnetName"u8))
                {
                    recoverySubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryVirtualMachineScaleSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryVirtualMachineScaleSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryCapacityReservationGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryCapacityReservationGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autoProtectionOfDataDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoProtectionOfDataDisk = new AutoProtectionOfDataDisk(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AEnableProtectionContent(instanceType, serializedAdditionalRawData, fabricObjectId, recoveryContainerId.Value, recoveryResourceGroupId.Value, recoveryCloudServiceId.Value, recoveryAvailabilitySetId.Value, recoveryProximityPlacementGroupId.Value, Optional.ToList(vmDisks), Optional.ToList(vmManagedDisks), multiVmGroupName.Value, multiVmGroupId.Value, recoveryBootDiagStorageAccountId.Value, diskEncryptionInfo.Value, recoveryAvailabilityZone.Value, recoveryExtendedLocation.Value, recoveryAzureNetworkId.Value, recoverySubnetName.Value, recoveryVirtualMachineScaleSetId.Value, recoveryCapacityReservationGroupId.Value, Optional.ToNullable(autoProtectionOfDataDisk));
        }

        BinaryData IPersistableModel<A2AEnableProtectionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AEnableProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        A2AEnableProtectionContent IPersistableModel<A2AEnableProtectionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AEnableProtectionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AEnableProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AEnableProtectionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
