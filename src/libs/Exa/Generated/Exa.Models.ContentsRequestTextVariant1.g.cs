
#nullable enable

namespace Exa
{
    /// <summary>
    /// Advanced options for controlling text extraction. Use this when you need to limit text length or include HTML structure. Set `maxAgeHours: 0` to apply `includeHtmlTags`, `verbosity`, and section filters to freshly fetched content.
    /// </summary>
    public sealed partial class ContentsRequestTextVariant1
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
        /// Keeps the page's links in the returned text, in the chosen format. Links are removed from the text when omitted.<br/>
        /// - `full`: Each link as a markdown link, `[anchor](url)`.<br/>
        /// - `citation`: Each link as a numbered reference, `[anchor][n]`, with the URLs listed as `[n]: url` at the end of the text. A `maxCharacters` limit can cut off the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkStyle")]
        public string? LinkStyle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        public global::Exa.ContentsRequestTextVariant1Verbosity? Verbosity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeSections")]
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>? IncludeSections { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeSections")]
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>? ExcludeSections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestTextVariant1" /> class.
        /// </summary>
        /// <param name="maxCharacters"></param>
        /// <param name="includeHtmlTags"></param>
        /// <param name="linkStyle">
        /// Keeps the page's links in the returned text, in the chosen format. Links are removed from the text when omitted.<br/>
        /// - `full`: Each link as a markdown link, `[anchor](url)`.<br/>
        /// - `citation`: Each link as a numbered reference, `[anchor][n]`, with the URLs listed as `[n]: url` at the end of the text. A `maxCharacters` limit can cut off the list.
        /// </param>
        /// <param name="verbosity"></param>
        /// <param name="includeSections"></param>
        /// <param name="excludeSections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestTextVariant1(
            int? maxCharacters,
            bool? includeHtmlTags,
            string? linkStyle,
            global::Exa.ContentsRequestTextVariant1Verbosity? verbosity,
            global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1IncludeSectionsVariant1Item>? includeSections,
            global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextVariant1ExcludeSectionsVariant1Item>? excludeSections)
        {
            this.MaxCharacters = maxCharacters;
            this.IncludeHtmlTags = includeHtmlTags;
            this.LinkStyle = linkStyle;
            this.Verbosity = verbosity;
            this.IncludeSections = includeSections;
            this.ExcludeSections = excludeSections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestTextVariant1" /> class.
        /// </summary>
        public ContentsRequestTextVariant1()
        {
        }

    }
}