
#nullable enable

namespace Exa
{
    /// <summary>
    /// Specify the search parameters for the Monitor.<br/>
    /// By default, the search parameters (query, entity and criteria) from the last search are used when no parameters are provided.
    /// </summary>
    public sealed partial class MonitorBehaviorConfig
    {
        /// <summary>
        /// The query to search for. By default, the query from the last search is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The criteria to search for. By default, the criteria from the last search is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>? Criteria { get; set; }

        /// <summary>
        /// The entity to search for. By default, the entity from the last search/import is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.EntityJsonConverter))]
        public global::Exa.Entity? Entity { get; set; }

        /// <summary>
        /// The maximum number of results to find
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// The behaviour of the Search when it is added to a Webset.<br/>
        /// Default Value: append
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.MonitorBehaviorConfigBehaviorJsonConverter))]
        public global::Exa.MonitorBehaviorConfigBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBehaviorConfig" /> class.
        /// </summary>
        /// <param name="count">
        /// The maximum number of results to find
        /// </param>
        /// <param name="query">
        /// The query to search for. By default, the query from the last search is used.
        /// </param>
        /// <param name="criteria">
        /// The criteria to search for. By default, the criteria from the last search is used.
        /// </param>
        /// <param name="entity">
        /// The entity to search for. By default, the entity from the last search/import is used.
        /// </param>
        /// <param name="behavior">
        /// The behaviour of the Search when it is added to a Webset.<br/>
        /// Default Value: append
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorBehaviorConfig(
            double count,
            string? query,
            global::System.Collections.Generic.IList<global::Exa.MonitorBehaviorConfigCriteriaItem>? criteria,
            global::Exa.Entity? entity,
            global::Exa.MonitorBehaviorConfigBehavior? behavior)
        {
            this.Query = query;
            this.Criteria = criteria;
            this.Entity = entity;
            this.Count = count;
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBehaviorConfig" /> class.
        /// </summary>
        public MonitorBehaviorConfig()
        {
        }

    }
}