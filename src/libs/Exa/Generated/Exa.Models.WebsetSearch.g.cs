
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetSearch
    {
        /// <summary>
        /// The unique identifier for the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: webset_search
        /// </summary>
        /// <default>"webset_search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "webset_search";

        /// <summary>
        /// The status of the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetSearchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetSearchStatus Status { get; set; }

        /// <summary>
        /// The unique identifier for the Webset this search belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsetId { get; set; }

        /// <summary>
        /// The query used to create the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The entity the search will return results for.<br/>
        /// When no entity is provided during creation, we will automatically select the best entity based on the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.EntityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.Entity Entity { get; set; }

        /// <summary>
        /// The criteria the search will use to evaluate the results. If not provided, we will automatically generate them for you.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetSearchCriteriaItem> Criteria { get; set; }

        /// <summary>
        /// The number of results the search will attempt to find. The actual number of results may be less than this number depending on the search complexity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// The soft cap requested for matching people from the same current employer company, or null when no cap was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPeoplePerCompany")]
        public int? MaxPeoplePerCompany { get; set; }

        /// <summary>
        /// The behavior of the search when it is added to a Webset.<br/>
        /// - `override`: the search will replace the existing Items found in the Webset and evaluate them against the new criteria. Any Items that don't match the new criteria will be discarded.<br/>
        /// - `append`: the search will add the new Items found to the existing Webset. Any Items that don't match the new criteria will be discarded.<br/>
        /// Default Value: override
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetSearchBehaviorJsonConverter))]
        public global::Exa.WebsetSearchBehavior? Behavior { get; set; }

        /// <summary>
        /// Sources (existing imports or websets) used to omit certain results to be found during the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetSearchExcludeItem> Exclude { get; set; }

        /// <summary>
        /// The scope of the search. By default, there is no scope - thus searching the web.<br/>
        /// If provided during creation, the search will only be performed on the sources provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetSearchScopeItem> Scope { get; set; }

        /// <summary>
        /// The progress of the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetSearchProgress Progress { get; set; }

        /// <summary>
        /// Recall metrics for the search, null if not yet computed or requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recall")]
        public global::Exa.WebsetSearchRecall? Recall { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The date and time the search was canceled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public global::System.DateTime? CanceledAt { get; set; }

        /// <summary>
        /// The reason the search was canceled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetSearchCanceledReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetSearchCanceledReason CanceledReason { get; set; }

        /// <summary>
        /// The date and time the search was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the search was updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearch" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the search
        /// </param>
        /// <param name="status">
        /// The status of the search
        /// </param>
        /// <param name="websetId">
        /// The unique identifier for the Webset this search belongs to
        /// </param>
        /// <param name="query">
        /// The query used to create the search.
        /// </param>
        /// <param name="entity">
        /// The entity the search will return results for.<br/>
        /// When no entity is provided during creation, we will automatically select the best entity based on the query.
        /// </param>
        /// <param name="criteria">
        /// The criteria the search will use to evaluate the results. If not provided, we will automatically generate them for you.
        /// </param>
        /// <param name="count">
        /// The number of results the search will attempt to find. The actual number of results may be less than this number depending on the search complexity.
        /// </param>
        /// <param name="exclude">
        /// Sources (existing imports or websets) used to omit certain results to be found during the search.
        /// </param>
        /// <param name="scope">
        /// The scope of the search. By default, there is no scope - thus searching the web.<br/>
        /// If provided during creation, the search will only be performed on the sources provided.
        /// </param>
        /// <param name="progress">
        /// The progress of the search
        /// </param>
        /// <param name="canceledReason">
        /// The reason the search was canceled
        /// </param>
        /// <param name="createdAt">
        /// The date and time the search was created
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the search was updated
        /// </param>
        /// <param name="maxPeoplePerCompany">
        /// The soft cap requested for matching people from the same current employer company, or null when no cap was requested.
        /// </param>
        /// <param name="behavior">
        /// The behavior of the search when it is added to a Webset.<br/>
        /// - `override`: the search will replace the existing Items found in the Webset and evaluate them against the new criteria. Any Items that don't match the new criteria will be discarded.<br/>
        /// - `append`: the search will add the new Items found to the existing Webset. Any Items that don't match the new criteria will be discarded.<br/>
        /// Default Value: override
        /// </param>
        /// <param name="recall">
        /// Recall metrics for the search, null if not yet computed or requested.
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="canceledAt">
        /// The date and time the search was canceled
        /// </param>
        /// <param name="object">
        /// Default Value: webset_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetSearch(
            string id,
            global::Exa.WebsetSearchStatus status,
            string websetId,
            string query,
            global::Exa.Entity entity,
            global::System.Collections.Generic.IList<global::Exa.WebsetSearchCriteriaItem> criteria,
            double count,
            global::System.Collections.Generic.IList<global::Exa.WebsetSearchExcludeItem> exclude,
            global::System.Collections.Generic.IList<global::Exa.WebsetSearchScopeItem> scope,
            global::Exa.WebsetSearchProgress progress,
            global::Exa.WebsetSearchCanceledReason canceledReason,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int? maxPeoplePerCompany,
            global::Exa.WebsetSearchBehavior? behavior,
            global::Exa.WebsetSearchRecall? recall,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? canceledAt,
            string @object = "webset_search")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.WebsetId = websetId ?? throw new global::System.ArgumentNullException(nameof(websetId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Entity = entity;
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.Count = count;
            this.MaxPeoplePerCompany = maxPeoplePerCompany;
            this.Behavior = behavior;
            this.Exclude = exclude ?? throw new global::System.ArgumentNullException(nameof(exclude));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Progress = progress ?? throw new global::System.ArgumentNullException(nameof(progress));
            this.Recall = recall;
            this.Metadata = metadata;
            this.CanceledAt = canceledAt;
            this.CanceledReason = canceledReason;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearch" /> class.
        /// </summary>
        public WebsetSearch()
        {
        }

    }
}