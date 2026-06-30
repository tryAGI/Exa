
#nullable enable

namespace Exa
{
    /// <summary>
    /// Caller-provided key-value metadata for your own tracking.<br/>
    /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
    /// </summary>
    public sealed partial class CreateSearchMonitorResponseMetadata2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}