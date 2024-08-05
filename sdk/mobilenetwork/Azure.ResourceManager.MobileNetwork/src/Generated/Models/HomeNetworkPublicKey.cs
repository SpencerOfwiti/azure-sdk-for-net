// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// A key used for SUPI concealment.
    /// Serialized Name: HomeNetworkPublicKey
    /// </summary>
    public partial class HomeNetworkPublicKey
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

        /// <summary> Initializes a new instance of <see cref="HomeNetworkPublicKey"/>. </summary>
        /// <param name="id">
        /// The Home Network Public Key Identifier determines which public key was used to generate the SUCI sent to the AMF. See TS 23.003 Section 2.2B Section 5.
        /// Serialized Name: HomeNetworkPublicKey.id
        /// </param>
        public HomeNetworkPublicKey(int id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="HomeNetworkPublicKey"/>. </summary>
        /// <param name="id">
        /// The Home Network Public Key Identifier determines which public key was used to generate the SUCI sent to the AMF. See TS 23.003 Section 2.2B Section 5.
        /// Serialized Name: HomeNetworkPublicKey.id
        /// </param>
        /// <param name="uri">
        /// The URL of Azure Key Vault secret containing the private key, versioned or unversioned. For example: https://contosovault.vault.azure.net/secrets/mySuciPrivateKey/562a4bb76b524a1493a6afe8e536ee78.
        /// Serialized Name: HomeNetworkPublicKey.url
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HomeNetworkPublicKey(int id, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HomeNetworkPublicKey"/> for deserialization. </summary>
        internal HomeNetworkPublicKey()
        {
        }

        /// <summary>
        /// The Home Network Public Key Identifier determines which public key was used to generate the SUCI sent to the AMF. See TS 23.003 Section 2.2B Section 5.
        /// Serialized Name: HomeNetworkPublicKey.id
        /// </summary>
        [WirePath("id")]
        public int Id { get; set; }
        /// <summary>
        /// The URL of Azure Key Vault secret containing the private key, versioned or unversioned. For example: https://contosovault.vault.azure.net/secrets/mySuciPrivateKey/562a4bb76b524a1493a6afe8e536ee78.
        /// Serialized Name: HomeNetworkPublicKey.url
        /// </summary>
        [WirePath("url")]
        public Uri Uri { get; set; }
    }
}
