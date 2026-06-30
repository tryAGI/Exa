
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1ResearchOutputOutputCompleted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars CostDollars { get; set; }

        /// <summary>
        /// The complete research output as text. If outputSchema was provided, this is a JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Structured JSON object matching your outputSchema. Only present when outputSchema was provided and the output successfully validated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed")]
        public object? Parsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputCompleted" /> class.
        /// </summary>
        /// <param name="costDollars"></param>
        /// <param name="content">
        /// The complete research output as text. If outputSchema was provided, this is a JSON string.
        /// </param>
        /// <param name="outputType"></param>
        /// <param name="parsed">
        /// Structured JSON object matching your outputSchema. Only present when outputSchema was provided and the output successfully validated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1ResearchOutputOutputCompleted(
            global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars costDollars,
            string content,
            global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType outputType,
            object? parsed)
        {
            this.OutputType = outputType;
            this.CostDollars = costDollars ?? throw new global::System.ArgumentNullException(nameof(costDollars));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Parsed = parsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputCompleted" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1ResearchOutputOutputCompleted()
        {
        }

    }
}