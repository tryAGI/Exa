
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesResearchTopResearcherPerson2
    {
        /// <summary>
        /// Referenced person name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Referenced person entity identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearchTopResearcherPerson2" /> class.
        /// </summary>
        /// <param name="name">
        /// Referenced person name.
        /// </param>
        /// <param name="id">
        /// Referenced person entity identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesResearchTopResearcherPerson2(
            string? name,
            string? id)
        {
            this.Name = name;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearchTopResearcherPerson2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesResearchTopResearcherPerson2()
        {
        }

    }
}