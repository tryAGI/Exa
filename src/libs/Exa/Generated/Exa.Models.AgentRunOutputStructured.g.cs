
#nullable enable

namespace Exa
{
    /// <summary>
    /// Validated JSON matching `outputSchema`, or `null` when no schema was provided.
    /// </summary>
    public sealed partial class AgentRunOutputStructured
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}