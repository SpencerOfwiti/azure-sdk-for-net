// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a credential set. </summary>
    public partial class ContainerRegistryCredentialSetPatch
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentialSetPatch"/>. </summary>
        public ContainerRegistryCredentialSetPatch()
        {
            AuthCredentials = new ChangeTrackingList<ContainerRegistryAuthCredential>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCredentialSetPatch"/>. </summary>
        /// <param name="identity"> Identities associated with the resource. This is used to access the KeyVault secrets. </param>
        /// <param name="authCredentials">
        /// List of authentication credentials stored for an upstream.
        /// Usually consists of a primary and an optional secondary credential.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryCredentialSetPatch(ManagedServiceIdentity identity, IList<ContainerRegistryAuthCredential> authCredentials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            AuthCredentials = authCredentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Identities associated with the resource. This is used to access the KeyVault secrets. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// List of authentication credentials stored for an upstream.
        /// Usually consists of a primary and an optional secondary credential.
        /// </summary>
        [WirePath("properties.authCredentials")]
        public IList<ContainerRegistryAuthCredential> AuthCredentials { get; }
    }
}
