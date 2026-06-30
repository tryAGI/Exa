
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchPaperEntity
    {
        /// <summary>
        /// Default Value: research_paper
        /// </summary>
        /// <default>"research_paper"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "research_paper";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchPaperEntity" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: research_paper
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchPaperEntity(
            string type = "research_paper")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchPaperEntity" /> class.
        /// </summary>
        public ResearchPaperEntity()
        {
        }

    }
}