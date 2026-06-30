
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSearchMonitorParameters
    {
        /// <summary>
        /// An optional name for the monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchMonitorSearch Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::Exa.SearchMonitorTrigger? Trigger { get; set; }

        /// <summary>
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>? OutputSchema { get; set; }

        /// <summary>
        /// Optional key-value metadata. Echoed back in webhook deliveries so you can route updates to systems like Slack.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </summary>
        /// <example>{"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchMonitorWebhook Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchMonitorParameters" /> class.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="webhook"></param>
        /// <param name="name">
        /// An optional name for the monitor
        /// </param>
        /// <param name="trigger"></param>
        /// <param name="outputSchema">
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </param>
        /// <param name="metadata">
        /// Optional key-value metadata. Echoed back in webhook deliveries so you can route updates to systems like Slack.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSearchMonitorParameters(
            global::Exa.SearchMonitorSearch search,
            global::Exa.SearchMonitorWebhook webhook,
            string? name,
            global::Exa.SearchMonitorTrigger? trigger,
            global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>? outputSchema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.Trigger = trigger;
            this.OutputSchema = outputSchema;
            this.Metadata = metadata;
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchMonitorParameters" /> class.
        /// </summary>
        public CreateSearchMonitorParameters()
        {
        }

    }
}