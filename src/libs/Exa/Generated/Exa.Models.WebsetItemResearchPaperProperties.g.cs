
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemResearchPaperProperties
    {
        /// <summary>
        /// Default Value: research_paper
        /// </summary>
        /// <default>"research_paper"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "research_paper";

        /// <summary>
        /// The URL of the research paper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Short description of the relevance of the research paper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The text content of the research paper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("researchPaper")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetItemResearchPaperPropertiesResearchPaper ResearchPaper { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemResearchPaperProperties" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the research paper
        /// </param>
        /// <param name="description">
        /// Short description of the relevance of the research paper
        /// </param>
        /// <param name="researchPaper"></param>
        /// <param name="content">
        /// The text content of the research paper
        /// </param>
        /// <param name="type">
        /// Default Value: research_paper
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemResearchPaperProperties(
            string url,
            string description,
            global::Exa.WebsetItemResearchPaperPropertiesResearchPaper researchPaper,
            string? content,
            string type = "research_paper")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Content = content;
            this.ResearchPaper = researchPaper ?? throw new global::System.ArgumentNullException(nameof(researchPaper));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemResearchPaperProperties" /> class.
        /// </summary>
        public WebsetItemResearchPaperProperties()
        {
        }

    }
}