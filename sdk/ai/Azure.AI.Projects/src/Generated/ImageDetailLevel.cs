// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> Specifies an image's detail level. Can be 'auto', 'low', 'high', or an unknown future value. </summary>
    public readonly partial struct ImageDetailLevel : IEquatable<ImageDetailLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageDetailLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageDetailLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string LowValue = "low";
        private const string HighValue = "high";

        /// <summary> Automatically select an appropriate detail level. </summary>
        public static ImageDetailLevel Auto { get; } = new ImageDetailLevel(AutoValue);
        /// <summary> Use a lower detail level to reduce bandwidth or cost. </summary>
        public static ImageDetailLevel Low { get; } = new ImageDetailLevel(LowValue);
        /// <summary> Use a higher detail level—potentially more resource-intensive. </summary>
        public static ImageDetailLevel High { get; } = new ImageDetailLevel(HighValue);
        /// <summary> Determines if two <see cref="ImageDetailLevel"/> values are the same. </summary>
        public static bool operator ==(ImageDetailLevel left, ImageDetailLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageDetailLevel"/> values are not the same. </summary>
        public static bool operator !=(ImageDetailLevel left, ImageDetailLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ImageDetailLevel"/>. </summary>
        public static implicit operator ImageDetailLevel(string value) => new ImageDetailLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageDetailLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageDetailLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
