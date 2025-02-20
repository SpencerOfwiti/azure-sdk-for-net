// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. </summary>
    public readonly partial struct AcceptGrowCapacityPoolForShortTermCloneSplit : IEquatable<AcceptGrowCapacityPoolForShortTermCloneSplit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AcceptGrowCapacityPoolForShortTermCloneSplit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AcceptGrowCapacityPoolForShortTermCloneSplit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string DeclinedValue = "Declined";

        /// <summary> Auto grow capacity pool for short term clone split is accepted. </summary>
        public static AcceptGrowCapacityPoolForShortTermCloneSplit Accepted { get; } = new AcceptGrowCapacityPoolForShortTermCloneSplit(AcceptedValue);
        /// <summary> Auto grow capacity pool for short term clone split is declined. Short term clone volume creation will not be allowed, to create short term clone volume accept auto grow capacity pool. </summary>
        public static AcceptGrowCapacityPoolForShortTermCloneSplit Declined { get; } = new AcceptGrowCapacityPoolForShortTermCloneSplit(DeclinedValue);
        /// <summary> Determines if two <see cref="AcceptGrowCapacityPoolForShortTermCloneSplit"/> values are the same. </summary>
        public static bool operator ==(AcceptGrowCapacityPoolForShortTermCloneSplit left, AcceptGrowCapacityPoolForShortTermCloneSplit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AcceptGrowCapacityPoolForShortTermCloneSplit"/> values are not the same. </summary>
        public static bool operator !=(AcceptGrowCapacityPoolForShortTermCloneSplit left, AcceptGrowCapacityPoolForShortTermCloneSplit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AcceptGrowCapacityPoolForShortTermCloneSplit"/>. </summary>
        public static implicit operator AcceptGrowCapacityPoolForShortTermCloneSplit(string value) => new AcceptGrowCapacityPoolForShortTermCloneSplit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AcceptGrowCapacityPoolForShortTermCloneSplit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AcceptGrowCapacityPoolForShortTermCloneSplit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
