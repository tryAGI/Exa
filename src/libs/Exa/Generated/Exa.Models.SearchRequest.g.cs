
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDomains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeDomains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startCrawlDate")]
        public global::System.DateTime? StartCrawlDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCrawlDate")]
        public global::System.DateTime? EndCrawlDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startPublishedDate")]
        public global::System.DateTime? StartPublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endPublishedDate")]
        public global::System.DateTime? EndPublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public bool? Moderation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::Exa.ContentsOptions? Contents { get; set; }

        /// <summary>
        /// The query string for the search.<br/>
        /// Example: Latest developments in LLM capabilities
        /// </summary>
        /// <example>Latest developments in LLM capabilities</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalQueries")]
        public global::System.Collections.Generic.IList<string>? AdditionalQueries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Exa.SearchRequestType2? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Exa.SearchRequestCategory2? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLocation")]
        public string? UserLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliance")]
        public global::Exa.SearchRequestCompliance2? Compliance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::Exa.OneOf<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The query string for the search.<br/>
        /// Example: Latest developments in LLM capabilities
        /// </param>
        /// <param name="includeDomains"></param>
        /// <param name="excludeDomains"></param>
        /// <param name="startCrawlDate"></param>
        /// <param name="endCrawlDate"></param>
        /// <param name="startPublishedDate"></param>
        /// <param name="endPublishedDate"></param>
        /// <param name="numResults"></param>
        /// <param name="context"></param>
        /// <param name="moderation"></param>
        /// <param name="contents"></param>
        /// <param name="additionalQueries"></param>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <param name="userLocation"></param>
        /// <param name="compliance"></param>
        /// <param name="outputSchema"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="stream"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequest(
            string query,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.DateTime? startCrawlDate,
            global::System.DateTime? endCrawlDate,
            global::System.DateTime? startPublishedDate,
            global::System.DateTime? endPublishedDate,
            int? numResults,
            global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>? context,
            bool? moderation,
            global::Exa.ContentsOptions? contents,
            global::System.Collections.Generic.IList<string>? additionalQueries,
            global::Exa.SearchRequestType2? type,
            global::Exa.SearchRequestCategory2? category,
            string? userLocation,
            global::Exa.SearchRequestCompliance2? compliance,
            global::Exa.OneOf<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>? outputSchema,
            string? systemPrompt,
            bool? stream)
        {
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.StartCrawlDate = startCrawlDate;
            this.EndCrawlDate = endCrawlDate;
            this.StartPublishedDate = startPublishedDate;
            this.EndPublishedDate = endPublishedDate;
            this.NumResults = numResults;
            this.Context = context;
            this.Moderation = moderation;
            this.Contents = contents;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.AdditionalQueries = additionalQueries;
            this.Type = type;
            this.Category = category;
            this.UserLocation = userLocation;
            this.Compliance = compliance;
            this.OutputSchema = outputSchema;
            this.SystemPrompt = systemPrompt;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }

    }
}