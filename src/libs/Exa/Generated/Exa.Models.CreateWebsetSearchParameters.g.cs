
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebsetSearchParameters
    {
        /// <summary>
        /// Number of Items the Search will attempt to find.<br/>
        /// The actual number of Items found may be less than this number depending on the query complexity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Natural language search query describing what you are looking for.<br/>
        /// Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.<br/>
        /// Any URLs provided will be crawled and used as additional context for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Entity the search will return results for.<br/>
        /// It is not required to provide it, we automatically detect the entity from all the information provided in the query. Only use this when you need more fine control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.EntityJsonConverter))]
        public global::Exa.Entity? Entity { get; set; }

        /// <summary>
        /// Criteria every item is evaluated against.<br/>
        /// It's not required to provide your own criteria, we automatically detect the criteria from all the information provided in the query. Only use this when you need more fine control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? Criteria { get; set; }

        /// <summary>
        /// Optional soft cap for people searches. When set, the search will try to include at most this many matching people from the same current employer company.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPeoplePerCompany")]
        public int? MaxPeoplePerCompany { get; set; }

        /// <summary>
        /// Sources (existing imports or websets) to exclude from search results. Any results found within these sources will be omitted to prevent finding them during search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// Limit the search to specific sources (existing imports). Any results found within these sources matching the search criteria will be included in the Webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>? Scope { get; set; }

        /// <summary>
        /// Whether to provide an estimate of how many total relevant results could exist for this search.<br/>
        /// Result of the analysis will be available in the `recall` field within the search request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall")]
        public bool? Recall { get; set; }

        /// <summary>
        /// How this search interacts with existing items in the Webset:<br/>
        /// - **override**: Replace existing items and evaluate all items against new criteria<br/>
        /// - **append**: Add new items to existing ones, keeping items that match the new criteria<br/>
        /// Default Value: override
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetSearchBehaviorJsonConverter))]
        public global::Exa.WebsetSearchBehavior? Behavior { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetSearchParameters" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of Items the Search will attempt to find.<br/>
        /// The actual number of Items found may be less than this number depending on the query complexity.
        /// </param>
        /// <param name="query">
        /// Natural language search query describing what you are looking for.<br/>
        /// Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.<br/>
        /// Any URLs provided will be crawled and used as additional context for the search.
        /// </param>
        /// <param name="entity">
        /// Entity the search will return results for.<br/>
        /// It is not required to provide it, we automatically detect the entity from all the information provided in the query. Only use this when you need more fine control.
        /// </param>
        /// <param name="criteria">
        /// Criteria every item is evaluated against.<br/>
        /// It's not required to provide your own criteria, we automatically detect the criteria from all the information provided in the query. Only use this when you need more fine control.
        /// </param>
        /// <param name="maxPeoplePerCompany">
        /// Optional soft cap for people searches. When set, the search will try to include at most this many matching people from the same current employer company.
        /// </param>
        /// <param name="exclude">
        /// Sources (existing imports or websets) to exclude from search results. Any results found within these sources will be omitted to prevent finding them during search.
        /// </param>
        /// <param name="scope">
        /// Limit the search to specific sources (existing imports). Any results found within these sources matching the search criteria will be included in the Webset.
        /// </param>
        /// <param name="recall">
        /// Whether to provide an estimate of how many total relevant results could exist for this search.<br/>
        /// Result of the analysis will be available in the `recall` field within the search request.
        /// </param>
        /// <param name="behavior">
        /// How this search interacts with existing items in the Webset:<br/>
        /// - **override**: Replace existing items and evaluate all items against new criteria<br/>
        /// - **append**: Add new items to existing ones, keeping items that match the new criteria<br/>
        /// Default Value: override
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebsetSearchParameters(
            double count,
            string query,
            global::Exa.Entity? entity,
            global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? criteria,
            int? maxPeoplePerCompany,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>? exclude,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>? scope,
            bool? recall,
            global::Exa.WebsetSearchBehavior? behavior,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Count = count;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Entity = entity;
            this.Criteria = criteria;
            this.MaxPeoplePerCompany = maxPeoplePerCompany;
            this.Exclude = exclude;
            this.Scope = scope;
            this.Recall = recall;
            this.Behavior = behavior;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetSearchParameters" /> class.
        /// </summary>
        public CreateWebsetSearchParameters()
        {
        }

    }
}