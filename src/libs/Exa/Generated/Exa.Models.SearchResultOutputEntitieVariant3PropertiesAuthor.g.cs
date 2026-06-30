
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant3PropertiesAuthor
    {
        /// <summary>
        /// Author display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Resolved person entity identifier, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant3PropertiesAuthor" /> class.
        /// </summary>
        /// <param name="name">
        /// Author display name.
        /// </param>
        /// <param name="id">
        /// Resolved person entity identifier, when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant3PropertiesAuthor(
            string? name,
            string? id)
        {
            this.Name = name;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant3PropertiesAuthor" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant3PropertiesAuthor()
        {
        }

    }
}