
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3TaskOperationDataThink
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataThinkTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThinkType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskOperationDataThink" /> class.
        /// </summary>
        /// <param name="content">
        /// The AI's reasoning process and decision-making steps
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant3TaskOperationDataThink(
            string content,
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataThinkType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskOperationDataThink" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3TaskOperationDataThink()
        {
        }

    }
}