
#nullable enable

namespace Exa
{
    /// <summary>
    /// Advanced options for controlling text extraction. Use this when you need to limit text length or include HTML structure.
    /// </summary>
    public sealed partial class SearchMonitorContentsText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeHtmlTags")]
        public bool? IncludeHtmlTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        public global::Exa.SearchMonitorContentsTextVerbosity2? Verbosity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeSections")]
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>? IncludeSections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeSections")]
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>? ExcludeSections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContentsText" /> class.
        /// </summary>
        /// <param name="maxCharacters"></param>
        /// <param name="includeHtmlTags"></param>
        /// <param name="verbosity"></param>
        /// <param name="includeSections"></param>
        /// <param name="excludeSections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorContentsText(
            int? maxCharacters,
            bool? includeHtmlTags,
            global::Exa.SearchMonitorContentsTextVerbosity2? verbosity,
            global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextIncludeSectionsVariant1Item>? includeSections,
            global::System.Collections.Generic.IList<global::Exa.SearchMonitorContentsTextExcludeSectionsVariant1Item>? excludeSections)
        {
            this.MaxCharacters = maxCharacters;
            this.IncludeHtmlTags = includeHtmlTags;
            this.Verbosity = verbosity;
            this.IncludeSections = includeSections;
            this.ExcludeSections = excludeSections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContentsText" /> class.
        /// </summary>
        public SearchMonitorContentsText()
        {
        }

    }
}