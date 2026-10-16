
#nullable enable

namespace Exa
{
    /// <summary>
    /// Request body for the target route. Must be a JSON object; `stream: true` is not allowed.
    /// </summary>
    public sealed partial class BatchRequestItemBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}