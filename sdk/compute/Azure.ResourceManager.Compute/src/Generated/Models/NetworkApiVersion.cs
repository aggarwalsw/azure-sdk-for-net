// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations. </summary>
    public readonly partial struct NetworkApiVersion : IEquatable<NetworkApiVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkApiVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkApiVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string v2020_11_01Value = "2020-11-01";
        private const string v2022_11_01Value = "2022-11-01";
        /// <summary> Determines if two <see cref="NetworkApiVersion"/> values are the same. </summary>
        public static bool operator ==(NetworkApiVersion left, NetworkApiVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkApiVersion"/> values are not the same. </summary>
        public static bool operator !=(NetworkApiVersion left, NetworkApiVersion right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetworkApiVersion"/>. </summary>
        public static implicit operator NetworkApiVersion(string value) => new NetworkApiVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkApiVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkApiVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
