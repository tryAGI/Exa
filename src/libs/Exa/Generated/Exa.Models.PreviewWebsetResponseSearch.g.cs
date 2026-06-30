
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewWebsetResponseSearch
    {
        /// <summary>
        /// Detected entity from the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity> Entity { get; set; }

        /// <summary>
        /// Detected criteria from the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem> Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetResponseSearch" /> class.
        /// </summary>
        /// <param name="entity">
        /// Detected entity from the query.
        /// </param>
        /// <param name="criteria">
        /// Detected criteria from the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewWebsetResponseSearch(
            global::Exa.OneOf<global::Exa.CompanyEntity, global::Exa.PersonEntity, global::Exa.ArticleEntity, global::Exa.ResearchPaperEntity, global::Exa.CustomEntity> entity,
            global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseSearchCriteriaItem> criteria)
        {
            this.Entity = entity;
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetResponseSearch" /> class.
        /// </summary>
        public PreviewWebsetResponseSearch()
        {
        }

    }
}