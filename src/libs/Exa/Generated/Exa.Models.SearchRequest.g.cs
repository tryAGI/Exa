
#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public bool? Moderation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::Exa.ContentsOptions? Contents { get; set; }

        /// <summary>
        /// The query string for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalQueries")]
        public global::System.Collections.Generic.IList<string>? AdditionalQueries { get; set; }

        /// <summary>
        /// The search mode to use. Defaults to `auto`, a balanced mode recommended for most applications.<br/>
        /// - `instant`: Optimized for minimum response time, trading some search depth for speed in real-time experiences such as chat, voice agents, and autocomplete.<br/>
        /// - `fast`: Returns high-quality results with reduced latency, making it a good fit for user-facing search and interactive workflows.<br/>
        /// - `auto`: The default. A balanced mode that optimizes for both quality and speed and is recommended for most applications.<br/>
        /// - `deep-lite`: Performs lightweight research with synthesized results and a consistent 4-second latency, lower than full deep search.<br/>
        /// - `deep`: Conducts comprehensive multi-step research with synthesis.<br/>
        /// - `deep-reasoning`: Adds stronger reasoning to `deep` for complex analysis and decision-making tasks.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Exa.SearchRequestCategory? Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLocation")]
        public global::Exa.OneOf<string, global::Exa.SearchRequestUserLocationVariant1Variant2, global::Exa.SearchRequestUserLocationVariant1Variant3>? UserLocation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliance")]
        public global::Exa.SearchRequestCompliance? Compliance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::Exa.SearchRequestOutputSchema? OutputSchema { get; set; }

        /// <summary>
        /// The broader goal this search serves: the task the caller is working on, beyond the query itself. When exposing this field to an agent as a tool parameter, describe it as: "Goal for this search turn; say which documents should rank first, which should be excluded, and what specific facts or figures to pull from them."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective")]
        public string? Objective { get; set; }

        /// <summary>
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </summary>
        /// <example>7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIdentifier")]
        public string? UserIdentifier { get; set; }

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
        /// Deprecated. List of strings that must be present in the webpage text of results. Matching is approximate (word-level rather than exact phrase), so a multi-word entry can match pages where its words appear separately. Up to 50 strings, each up to 4096 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeText")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? IncludeText { get; set; }

        /// <summary>
        /// Deprecated. List of strings that must not be present in the webpage text of results. Matching is approximate (word-level rather than exact phrase). Up to 50 strings, each up to 4096 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeText")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ExcludeText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The query string for the search.
        /// </param>
        /// <param name="includeDomains"></param>
        /// <param name="excludeDomains"></param>
        /// <param name="startPublishedDate"></param>
        /// <param name="endPublishedDate"></param>
        /// <param name="numResults"></param>
        /// <param name="moderation"></param>
        /// <param name="contents"></param>
        /// <param name="additionalQueries"></param>
        /// <param name="type">
        /// The search mode to use. Defaults to `auto`, a balanced mode recommended for most applications.<br/>
        /// - `instant`: Optimized for minimum response time, trading some search depth for speed in real-time experiences such as chat, voice agents, and autocomplete.<br/>
        /// - `fast`: Returns high-quality results with reduced latency, making it a good fit for user-facing search and interactive workflows.<br/>
        /// - `auto`: The default. A balanced mode that optimizes for both quality and speed and is recommended for most applications.<br/>
        /// - `deep-lite`: Performs lightweight research with synthesized results and a consistent 4-second latency, lower than full deep search.<br/>
        /// - `deep`: Conducts comprehensive multi-step research with synthesis.<br/>
        /// - `deep-reasoning`: Adds stronger reasoning to `deep` for complex analysis and decision-making tasks.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="category"></param>
        /// <param name="userLocation"></param>
        /// <param name="compliance"></param>
        /// <param name="outputSchema"></param>
        /// <param name="objective">
        /// The broader goal this search serves: the task the caller is working on, beyond the query itself. When exposing this field to an agent as a tool parameter, describe it as: "Goal for this search turn; say which documents should rank first, which should be excluded, and what specific facts or figures to pull from them."
        /// </param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
        /// <param name="systemPrompt"></param>
        /// <param name="stream"></param>
        /// <param name="startCrawlDate"></param>
        /// <param name="endCrawlDate"></param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequest(
            string query,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.DateTime? startPublishedDate,
            global::System.DateTime? endPublishedDate,
            int? numResults,
            bool? moderation,
            global::Exa.ContentsOptions? contents,
            global::System.Collections.Generic.IList<string>? additionalQueries,
            string? type,
            global::Exa.SearchRequestCategory? category,
            global::Exa.OneOf<string, global::Exa.SearchRequestUserLocationVariant1Variant2, global::Exa.SearchRequestUserLocationVariant1Variant3>? userLocation,
            global::Exa.SearchRequestCompliance? compliance,
            global::Exa.SearchRequestOutputSchema? outputSchema,
            string? objective,
            string? userIdentifier,
            string? systemPrompt,
            bool? stream,
            global::System.DateTime? startCrawlDate,
            global::System.DateTime? endCrawlDate,
            global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>? context)
        {
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.StartPublishedDate = startPublishedDate;
            this.EndPublishedDate = endPublishedDate;
            this.NumResults = numResults;
            this.Moderation = moderation;
            this.Contents = contents;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.AdditionalQueries = additionalQueries;
            this.Type = type;
            this.Category = category;
            this.UserLocation = userLocation;
            this.Compliance = compliance;
            this.OutputSchema = outputSchema;
            this.Objective = objective;
            this.UserIdentifier = userIdentifier;
            this.SystemPrompt = systemPrompt;
            this.Stream = stream;
            this.StartCrawlDate = startCrawlDate;
            this.EndCrawlDate = endCrawlDate;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }

    }
}