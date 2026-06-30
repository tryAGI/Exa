
#nullable enable

namespace Exa
{
    /// <summary>
    /// Why the run stopped. `null` while the run is queued or running.
    /// </summary>
    public sealed partial class AgentRunStopReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}