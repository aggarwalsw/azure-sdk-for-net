// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> The status of the current operation. </summary>
    public readonly partial struct MigrationAssessmentProvisioningState : IEquatable<MigrationAssessmentProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MigrationAssessmentProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MigrationAssessmentProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string AcceptedValue = "Accepted";

        /// <summary> Resource has been created. </summary>
        public static MigrationAssessmentProvisioningState Succeeded { get; } = new MigrationAssessmentProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static MigrationAssessmentProvisioningState Failed { get; } = new MigrationAssessmentProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static MigrationAssessmentProvisioningState Canceled { get; } = new MigrationAssessmentProvisioningState(CanceledValue);
        /// <summary> Resource is being Provisioned. </summary>
        public static MigrationAssessmentProvisioningState Provisioning { get; } = new MigrationAssessmentProvisioningState(ProvisioningValue);
        /// <summary> Resource is being Updated. </summary>
        public static MigrationAssessmentProvisioningState Updating { get; } = new MigrationAssessmentProvisioningState(UpdatingValue);
        /// <summary> Resource is being Deleted. </summary>
        public static MigrationAssessmentProvisioningState Deleting { get; } = new MigrationAssessmentProvisioningState(DeletingValue);
        /// <summary> Resource is being Accepted. </summary>
        public static MigrationAssessmentProvisioningState Accepted { get; } = new MigrationAssessmentProvisioningState(AcceptedValue);
        /// <summary> Determines if two <see cref="MigrationAssessmentProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MigrationAssessmentProvisioningState left, MigrationAssessmentProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MigrationAssessmentProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MigrationAssessmentProvisioningState left, MigrationAssessmentProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MigrationAssessmentProvisioningState"/>. </summary>
        public static implicit operator MigrationAssessmentProvisioningState(string value) => new MigrationAssessmentProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MigrationAssessmentProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MigrationAssessmentProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
