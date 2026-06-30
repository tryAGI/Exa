
#nullable enable

namespace Exa
{
    /// <summary>
    /// JSON Schema to enforce structured output. When provided, the research output will be validated against this schema and returned as parsed JSON.
    /// </summary>
    public sealed partial class ResearchCreateRequestDtoClassOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}