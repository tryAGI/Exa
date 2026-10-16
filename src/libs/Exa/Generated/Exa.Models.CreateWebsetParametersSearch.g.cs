
#nullable enable

namespace Exa
{
    /// <summary>
    /// Create initial search for the Webset.
    /// </summary>
    public sealed partial class CreateWebsetParametersSearch
    {
        /// <summary>
        /// Natural language search query describing what you are looking for.<br/>
        /// Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.<br/>
        /// Any URLs provided will be crawled and used as additional context for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Number of Items the Webset will attempt to find.<br/>
        /// The actual number of Items found may be less than this number depending on the search complexity.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public double? Count { get; set; }

        /// <summary>
        /// Entity the Webset returns results for. Detected from the query when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.EntityJsonConverter))]
        public global::Exa.Entity? Entity { get; set; }

        /// <summary>
        /// Criteria every Item is evaluated against. Generated from the query when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? Criteria { get; set; }

        /// <summary>
        /// Optional soft cap for people searches. When set, the search will try to include at most this many matching people from the same current employer company.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPeoplePerCompany")]
        public int? MaxPeoplePerCompany { get; set; }

        /// <summary>
        /// Whether to estimate how many relevant results exist for this search. The estimate is returned in the search's `recall` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall")]
        public bool? Recall { get; set; }

        /// <summary>
        /// Imports or Websets whose items are left out of this search's results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// Limit the search to specific sources (existing imports or websets). Any results found within these sources matching the search criteria will be included in the Webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchScopeItem>? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParametersSearch" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural language search query describing what you are looking for.<br/>
        /// Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.<br/>
        /// Any URLs provided will be crawled and used as additional context for the search.
        /// </param>
        /// <param name="count">
        /// Number of Items the Webset will attempt to find.<br/>
        /// The actual number of Items found may be less than this number depending on the search complexity.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="entity">
        /// Entity the Webset returns results for. Detected from the query when omitted.
        /// </param>
        /// <param name="criteria">
        /// Criteria every Item is evaluated against. Generated from the query when omitted.
        /// </param>
        /// <param name="maxPeoplePerCompany">
        /// Optional soft cap for people searches. When set, the search will try to include at most this many matching people from the same current employer company.
        /// </param>
        /// <param name="recall">
        /// Whether to estimate how many relevant results exist for this search. The estimate is returned in the search's `recall` field.
        /// </param>
        /// <param name="exclude">
        /// Imports or Websets whose items are left out of this search's results.
        /// </param>
        /// <param name="scope">
        /// Limit the search to specific sources (existing imports or websets). Any results found within these sources matching the search criteria will be included in the Webset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebsetParametersSearch(
            string query,
            double? count,
            global::Exa.Entity? entity,
            global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? criteria,
            int? maxPeoplePerCompany,
            bool? recall,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchExcludeItem>? exclude,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersSearchScopeItem>? scope)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Count = count;
            this.Entity = entity;
            this.Criteria = criteria;
            this.MaxPeoplePerCompany = maxPeoplePerCompany;
            this.Recall = recall;
            this.Exclude = exclude;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParametersSearch" /> class.
        /// </summary>
        public CreateWebsetParametersSearch()
        {
        }

    }
}