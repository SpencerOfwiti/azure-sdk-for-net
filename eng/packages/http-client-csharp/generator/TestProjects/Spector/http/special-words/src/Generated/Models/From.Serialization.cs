// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class From : IJsonModel<From>
    {
        void IJsonModel<From>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        From IJsonModel<From>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual From JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<From>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        From IPersistableModel<From>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual From PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<From>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="from"> The <see cref="From"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(From @from) => throw null;

        public static explicit operator From(Response result) => throw null;
    }
}
