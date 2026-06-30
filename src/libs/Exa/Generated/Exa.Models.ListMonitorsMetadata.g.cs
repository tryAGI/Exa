
#nullable enable

namespace Exa
{
    /// <summary>
    /// Filter monitors by metadata key-value pairs (exact match, AND semantics). Use bracket notation: `metadata[key]=value`.
    /// </summary>
    public sealed partial class ListMonitorsMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}