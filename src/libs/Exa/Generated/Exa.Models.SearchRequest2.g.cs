
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequest2
    {
        /// <summary>
        /// The query string for the search.<br/>
        /// Example: Latest developments in LLM capabilities
        /// </summary>
        /// <example>Latest developments in LLM capabilities</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional query variations for deep search. Only works with type="deep" or type="deep-reasoning". When provided, these queries are used alongside the main query for comprehensive results.<br/>
        /// Example: [LLM advancements, large language model progress]
        /// </summary>
        /// <example>[LLM advancements, large language model progress]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalQueries")]
        public global::System.Collections.Generic.IList<string>? AdditionalQueries { get; set; }

        /// <summary>
        /// The type of search. Neural uses an embeddings-based model, auto (default) intelligently combines neural and other search methods, fast uses streamlined versions of the search models, deep is light deep search, deep-reasoning is base deep search, and instant provides the lowest latency search optimized for real-time applications.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.SearchRequestTypeJsonConverter))]
        public global::Exa.SearchRequestType? Type { get; set; }

        /// <summary>
        /// JSON schema for deep search structured output mode. When provided, the output.content field is returned as structured JSON matching this schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// A data category to focus on. The `people` and `company` categories have improved quality for finding LinkedIn profiles and company pages. Note: The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `includeText`, `excludeText`, `excludeDomains`. For `people` category, `includeDomains` only accepts LinkedIn domains. Using unsupported parameters will result in a 400 error.<br/>
        /// Example: research paper
        /// </summary>
        /// <example>research paper</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.SearchRequestCategoryJsonConverter))]
        public global::Exa.SearchRequestCategory? Category { get; set; }

        /// <summary>
        /// The two-letter ISO country code of the user, e.g. US.<br/>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLocation")]
        public string? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest2" /> class.
        /// </summary>
        /// <param name="query">
        /// The query string for the search.<br/>
        /// Example: Latest developments in LLM capabilities
        /// </param>
        /// <param name="additionalQueries">
        /// Additional query variations for deep search. Only works with type="deep" or type="deep-reasoning". When provided, these queries are used alongside the main query for comprehensive results.<br/>
        /// Example: [LLM advancements, large language model progress]
        /// </param>
        /// <param name="type">
        /// The type of search. Neural uses an embeddings-based model, auto (default) intelligently combines neural and other search methods, fast uses streamlined versions of the search models, deep is light deep search, deep-reasoning is base deep search, and instant provides the lowest latency search optimized for real-time applications.<br/>
        /// Default Value: auto<br/>
        /// Example: auto
        /// </param>
        /// <param name="outputSchema">
        /// JSON schema for deep search structured output mode. When provided, the output.content field is returned as structured JSON matching this schema.
        /// </param>
        /// <param name="category">
        /// A data category to focus on. The `people` and `company` categories have improved quality for finding LinkedIn profiles and company pages. Note: The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `includeText`, `excludeText`, `excludeDomains`. For `people` category, `includeDomains` only accepts LinkedIn domains. Using unsupported parameters will result in a 400 error.<br/>
        /// Example: research paper
        /// </param>
        /// <param name="userLocation">
        /// The two-letter ISO country code of the user, e.g. US.<br/>
        /// Example: US
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequest2(
            string query,
            global::System.Collections.Generic.IList<string>? additionalQueries,
            global::Exa.SearchRequestType? type,
            object? outputSchema,
            global::Exa.SearchRequestCategory? category,
            string? userLocation)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.AdditionalQueries = additionalQueries;
            this.Type = type;
            this.OutputSchema = outputSchema;
            this.Category = category;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest2" /> class.
        /// </summary>
        public SearchRequest2()
        {
        }
    }
}