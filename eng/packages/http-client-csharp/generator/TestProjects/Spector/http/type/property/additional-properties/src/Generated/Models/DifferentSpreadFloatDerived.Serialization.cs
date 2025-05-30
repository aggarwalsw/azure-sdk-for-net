// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.AdditionalProperties
{
    public partial class DifferentSpreadFloatDerived : IJsonModel<DifferentSpreadFloatDerived>
    {
        void IJsonModel<DifferentSpreadFloatDerived>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        DifferentSpreadFloatDerived IJsonModel<DifferentSpreadFloatDerived>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected override DifferentSpreadFloatRecord JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<DifferentSpreadFloatDerived>.Write(ModelReaderWriterOptions options) => throw null;

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        DifferentSpreadFloatDerived IPersistableModel<DifferentSpreadFloatDerived>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected override DifferentSpreadFloatRecord PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<DifferentSpreadFloatDerived>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="differentSpreadFloatDerived"> The <see cref="DifferentSpreadFloatDerived"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(DifferentSpreadFloatDerived differentSpreadFloatDerived) => throw null;

        public static explicit operator DifferentSpreadFloatDerived(Response result) => throw null;
    }
}
