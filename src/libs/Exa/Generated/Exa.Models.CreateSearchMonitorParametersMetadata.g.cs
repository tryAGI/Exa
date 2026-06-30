
#nullable enable

namespace Exa
{
    /// <summary>
    /// Optional key-value metadata. Echoed back in webhook deliveries so you can route updates to systems like Slack.<br/>
    /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
    /// </summary>
    public sealed partial class CreateSearchMonitorParametersMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}