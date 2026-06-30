
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewWebsetParametersSearch
    {
        /// <summary>
        /// Natural language search query describing what you are looking for.<br/>
        /// Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Entity used to inform the decomposition.<br/>
        /// It is not required to provide it, we automatically detect the entity from all the information provided in the query. Only use this when you need more fine control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.EntityJsonConverter))]
        public global::Exa.Entity? Entity { get; set; }

        /// <summary>
        /// When query parameter search=true, the number of preview items to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public double? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetParametersSearch" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural language search query describing what you are looking for.<br/>
        /// Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.
        /// </param>
        /// <param name="entity">
        /// Entity used to inform the decomposition.<br/>
        /// It is not required to provide it, we automatically detect the entity from all the information provided in the query. Only use this when you need more fine control.
        /// </param>
        /// <param name="count">
        /// When query parameter search=true, the number of preview items to return.<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewWebsetParametersSearch(
            string query,
            global::Exa.Entity? entity,
            double? count)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Entity = entity;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetParametersSearch" /> class.
        /// </summary>
        public PreviewWebsetParametersSearch()
        {
        }

    }
}