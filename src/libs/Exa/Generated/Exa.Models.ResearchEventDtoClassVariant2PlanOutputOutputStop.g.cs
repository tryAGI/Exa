
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2PlanOutputOutputStop
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType OutputType { get; set; }

        /// <summary>
        /// Why the AI decided to stop researching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOutputOutputStop" /> class.
        /// </summary>
        /// <param name="reasoning">
        /// Why the AI decided to stop researching
        /// </param>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant2PlanOutputOutputStop(
            string reasoning,
            global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType outputType)
        {
            this.OutputType = outputType;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOutputOutputStop" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2PlanOutputOutputStop()
        {
        }

    }
}