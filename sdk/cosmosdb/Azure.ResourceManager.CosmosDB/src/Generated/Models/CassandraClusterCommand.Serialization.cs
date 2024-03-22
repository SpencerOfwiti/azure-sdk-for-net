// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterCommand : IUtf8JsonSerializable, IJsonModel<CassandraClusterCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterCommand>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraClusterCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterCommand)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Command))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStringValue(Command);
            }
            if (Optional.IsDefined(CommandId))
            {
                writer.WritePropertyName("commandId"u8);
                writer.WriteStringValue(CommandId);
            }
            if (Optional.IsDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Arguments);
#else
                using (JsonDocument document = JsonDocument.Parse(Arguments))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(IsAdmin))
            {
                writer.WritePropertyName("isAdmin"u8);
                writer.WriteBooleanValue(IsAdmin.Value);
            }
            if (Optional.IsDefined(ShouldStopCassandraBeforeStart))
            {
                writer.WritePropertyName("cassandraStopStart"u8);
                writer.WriteBooleanValue(ShouldStopCassandraBeforeStart.Value);
            }
            if (Optional.IsDefined(IsReadWrite))
            {
                writer.WritePropertyName("readWrite"u8);
                writer.WriteBooleanValue(IsReadWrite.Value);
            }
            if (Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(OutputFile))
            {
                writer.WritePropertyName("outputFile"u8);
                writer.WriteStringValue(OutputFile);
            }
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

        CassandraClusterCommand IJsonModel<CassandraClusterCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterCommand)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterCommand(document.RootElement, options);
        }

        internal static CassandraClusterCommand DeserializeCassandraClusterCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string command = default;
            string commandId = default;
            BinaryData arguments = default;
            string host = default;
            bool? isAdmin = default;
            bool? cassandraStopStart = default;
            bool? readWrite = default;
            string result = default;
            CommandStatus? status = default;
            string outputFile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("command"u8))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commandId"u8))
                {
                    commandId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arguments = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAdmin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cassandraStopStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cassandraStopStart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readWrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    result = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new CommandStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputFile"u8))
                {
                    outputFile = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraClusterCommand(
                command,
                commandId,
                arguments,
                host,
                isAdmin,
                cassandraStopStart,
                readWrite,
                result,
                status,
                outputFile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraClusterCommand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterCommand)} does not support '{options.Format}' format.");
            }
        }

        CassandraClusterCommand IPersistableModel<CassandraClusterCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterCommand(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterCommand)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterCommand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
