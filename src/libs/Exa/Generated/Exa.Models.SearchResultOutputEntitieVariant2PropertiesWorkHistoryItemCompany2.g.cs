
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemCompany2
    {
        /// <summary>
        /// Referenced company identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Referenced company name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemCompany2" /> class.
        /// </summary>
        /// <param name="id">
        /// Referenced company identifier.
        /// </param>
        /// <param name="name">
        /// Referenced company name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemCompany2(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemCompany2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemCompany2()
        {
        }

    }
}