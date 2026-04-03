
#nullable enable

namespace Exa
{
    /// <summary>
    /// Advanced options for controlling text extraction. Use this when you need to limit text length or include HTML structure.
    /// </summary>
    public sealed partial class ContentsRequestText
    {
        /// <summary>
        /// Maximum character limit for the full page text. Useful for controlling response size and API costs.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// Include HTML tags in the response, which can help LLMs understand text structure and formatting.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeHtmlTags")]
        public bool? IncludeHtmlTags { get; set; }

        /// <summary>
        /// Controls the verbosity level of returned content. Requires livecrawl: "always" to take effect.<br/>
        /// - compact: Most concise output, main content only (default)<br/>
        /// - standard: Balanced content with more detail<br/>
        /// - full: Complete content including all sections<br/>
        /// Default Value: compact<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ContentsRequestTextVerbosityJsonConverter))]
        public global::Exa.ContentsRequestTextVerbosity? Verbosity { get; set; }

        /// <summary>
        /// Only include content from these semantic page sections. Requires livecrawl: "always" to take effect.<br/>
        /// Example: [body, header]
        /// </summary>
        /// <example>[body, header]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeSections")]
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextIncludeSection>? IncludeSections { get; set; }

        /// <summary>
        /// Exclude content from these semantic page sections. Requires livecrawl: "always" to take effect.<br/>
        /// Example: [navigation, footer, sidebar]
        /// </summary>
        /// <example>[navigation, footer, sidebar]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeSections")]
        public global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextExcludeSection>? ExcludeSections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestText" /> class.
        /// </summary>
        /// <param name="maxCharacters">
        /// Maximum character limit for the full page text. Useful for controlling response size and API costs.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="includeHtmlTags">
        /// Include HTML tags in the response, which can help LLMs understand text structure and formatting.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="verbosity">
        /// Controls the verbosity level of returned content. Requires livecrawl: "always" to take effect.<br/>
        /// - compact: Most concise output, main content only (default)<br/>
        /// - standard: Balanced content with more detail<br/>
        /// - full: Complete content including all sections<br/>
        /// Default Value: compact<br/>
        /// Example: standard
        /// </param>
        /// <param name="includeSections">
        /// Only include content from these semantic page sections. Requires livecrawl: "always" to take effect.<br/>
        /// Example: [body, header]
        /// </param>
        /// <param name="excludeSections">
        /// Exclude content from these semantic page sections. Requires livecrawl: "always" to take effect.<br/>
        /// Example: [navigation, footer, sidebar]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestText(
            int? maxCharacters,
            bool? includeHtmlTags,
            global::Exa.ContentsRequestTextVerbosity? verbosity,
            global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextIncludeSection>? includeSections,
            global::System.Collections.Generic.IList<global::Exa.ContentsRequestTextExcludeSection>? excludeSections)
        {
            this.MaxCharacters = maxCharacters;
            this.IncludeHtmlTags = includeHtmlTags;
            this.Verbosity = verbosity;
            this.IncludeSections = includeSections;
            this.ExcludeSections = excludeSections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestText" /> class.
        /// </summary>
        public ContentsRequestText()
        {
        }
    }
}