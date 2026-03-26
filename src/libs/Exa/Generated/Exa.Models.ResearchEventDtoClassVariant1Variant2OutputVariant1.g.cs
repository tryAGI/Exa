
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1Variant2OutputVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant1CostDollars CostDollars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed")]
        public object? Parsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant2OutputVariant1" /> class.
        /// </summary>
        /// <param name="outputType"></param>
        /// <param name="costDollars"></param>
        /// <param name="content"></param>
        /// <param name="parsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1Variant2OutputVariant1(
            global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant1CostDollars costDollars,
            string content,
            global::Exa.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputType outputType,
            object? parsed)
        {
            this.CostDollars = costDollars ?? throw new global::System.ArgumentNullException(nameof(costDollars));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.OutputType = outputType;
            this.Parsed = parsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant2OutputVariant1" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1Variant2OutputVariant1()
        {
        }
    }
}