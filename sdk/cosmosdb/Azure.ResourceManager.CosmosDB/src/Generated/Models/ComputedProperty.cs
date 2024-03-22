// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The definition of a computed property. </summary>
    public partial class ComputedProperty
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComputedProperty"/>. </summary>
        public ComputedProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputedProperty"/>. </summary>
        /// <param name="name"> The name of a computed property, for example - "cp_lowerName". </param>
        /// <param name="query"> The query that evaluates the value for computed property, for example - "SELECT VALUE LOWER(c.name) FROM c". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputedProperty(string name, string query, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Query = query;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of a computed property, for example - "cp_lowerName". </summary>
        public string Name { get; set; }
        /// <summary> The query that evaluates the value for computed property, for example - "SELECT VALUE LOWER(c.name) FROM c". </summary>
        public string Query { get; set; }
    }
}
