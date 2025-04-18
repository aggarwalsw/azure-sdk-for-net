// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the evaluation result summary. </summary>
    public partial class ConversationAuthoringEvalSummary
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

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringEvalSummary"/>. </summary>
        /// <param name="entitiesEvaluation"> Contains the data related to entities evaluation. </param>
        /// <param name="intentsEvaluation"> Contains the data related to intents evaluation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entitiesEvaluation"/> or <paramref name="intentsEvaluation"/> is null. </exception>
        internal ConversationAuthoringEvalSummary(EntitiesEvaluationSummary entitiesEvaluation, IntentsEvaluationSummary intentsEvaluation)
        {
            Argument.AssertNotNull(entitiesEvaluation, nameof(entitiesEvaluation));
            Argument.AssertNotNull(intentsEvaluation, nameof(intentsEvaluation));

            EntitiesEvaluation = entitiesEvaluation;
            IntentsEvaluation = intentsEvaluation;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringEvalSummary"/>. </summary>
        /// <param name="entitiesEvaluation"> Contains the data related to entities evaluation. </param>
        /// <param name="intentsEvaluation"> Contains the data related to intents evaluation. </param>
        /// <param name="evaluationOptions"> The options that were used while running the evaluation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationAuthoringEvalSummary(EntitiesEvaluationSummary entitiesEvaluation, IntentsEvaluationSummary intentsEvaluation, ConversationAuthoringEvaluationDetails evaluationOptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EntitiesEvaluation = entitiesEvaluation;
            IntentsEvaluation = intentsEvaluation;
            EvaluationOptions = evaluationOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringEvalSummary"/> for deserialization. </summary>
        internal ConversationAuthoringEvalSummary()
        {
        }

        /// <summary> Contains the data related to entities evaluation. </summary>
        public EntitiesEvaluationSummary EntitiesEvaluation { get; }
        /// <summary> Contains the data related to intents evaluation. </summary>
        public IntentsEvaluationSummary IntentsEvaluation { get; }
        /// <summary> The options that were used while running the evaluation. </summary>
        public ConversationAuthoringEvaluationDetails EvaluationOptions { get; }
    }
}
