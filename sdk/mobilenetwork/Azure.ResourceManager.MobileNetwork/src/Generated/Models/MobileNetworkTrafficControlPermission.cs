// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// Traffic control permission.
    /// Serialized Name: TrafficControlPermission
    /// </summary>
    public readonly partial struct MobileNetworkTrafficControlPermission : IEquatable<MobileNetworkTrafficControlPermission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkTrafficControlPermission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkTrafficControlPermission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string BlockedValue = "Blocked";

        /// <summary>
        /// Traffic matching this rule is allowed to flow.
        /// Serialized Name: TrafficControlPermission.Enabled
        /// </summary>
        public static MobileNetworkTrafficControlPermission Enabled { get; } = new MobileNetworkTrafficControlPermission(EnabledValue);
        /// <summary>
        /// Traffic matching this rule is not allowed to flow.
        /// Serialized Name: TrafficControlPermission.Blocked
        /// </summary>
        public static MobileNetworkTrafficControlPermission Blocked { get; } = new MobileNetworkTrafficControlPermission(BlockedValue);
        /// <summary> Determines if two <see cref="MobileNetworkTrafficControlPermission"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkTrafficControlPermission left, MobileNetworkTrafficControlPermission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkTrafficControlPermission"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkTrafficControlPermission left, MobileNetworkTrafficControlPermission right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkTrafficControlPermission"/>. </summary>
        public static implicit operator MobileNetworkTrafficControlPermission(string value) => new MobileNetworkTrafficControlPermission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkTrafficControlPermission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkTrafficControlPermission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
