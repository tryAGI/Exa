
#nullable enable

namespace Exa
{
    /// <summary>
    /// Results from extras.<br/>
    /// Example: {"links":[]}
    /// </summary>
    public sealed partial class SearchResultOutputExtras
    {
        /// <summary>
        /// Array of links from the search result.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<string>? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputExtras" /> class.
        /// </summary>
        /// <param name="links">
        /// Array of links from the search result.<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputExtras(
            global::System.Collections.Generic.IList<string>? links)
        {
            this.Links = links;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputExtras" /> class.
        /// </summary>
        public SearchResultOutputExtras()
        {
        }

    }
}