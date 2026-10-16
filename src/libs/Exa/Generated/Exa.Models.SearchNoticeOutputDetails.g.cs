
#nullable enable

namespace Exa
{
    /// <summary>
    /// Optional extra context for a harness or model. An open object: no schema is promised for its keys, and it never carries information that `message` lacks.
    /// </summary>
    public sealed partial class SearchNoticeOutputDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}