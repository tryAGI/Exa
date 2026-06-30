
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2PlanOperationDataThink
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataThinkTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThinkType Type { get; set; }

        /// <summary>
        /// The AI's reasoning process and decision-making steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOperationDataThink" /> class.
        /// </summary>
        /// <param name="content">
        /// The AI's reasoning process and decision-making steps
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant2PlanOperationDataThink(
            string content,
            global::Exa.ResearchEventDtoClassVariant2PlanOperationDataThinkType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOperationDataThink" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2PlanOperationDataThink()
        {
        }

    }
}