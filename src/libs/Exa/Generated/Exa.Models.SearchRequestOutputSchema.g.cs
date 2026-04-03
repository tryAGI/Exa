
#nullable enable

namespace Exa
{
    /// <summary>
    /// JSON schema for deep search structured output mode. When provided, the output.content field is returned as structured JSON matching this schema.
    /// </summary>
    public sealed partial class SearchRequestOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}