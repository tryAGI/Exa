
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSearchMonitorResponse
    {
        /// <summary>
        /// The unique identifier for the monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An optional display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The status of the monitor. `active` monitors run on schedule and can be triggered manually. `paused` monitors can only be triggered manually. `disabled` monitors are auto-disabled after 10 consecutive authentication failures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateSearchMonitorResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CreateSearchMonitorResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchMonitorSearchOutput Search { get; set; }

        /// <summary>
        /// The interval-based schedule for automatic runs. Null if no schedule is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::Exa.SearchMonitorTriggerOutput? Trigger { get; set; }

        /// <summary>
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1, global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2>? OutputSchema { get; set; }

        /// <summary>
        /// Optional key-value metadata for your own tracking. Echoed back in webhook deliveries so you can route updates to systems like Slack.<br/>
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
        public required global::Exa.SearchMonitorWebhookOutput Webhook { get; set; }

        /// <summary>
        /// When the next scheduled run will occur. Null if no trigger is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextRunAt")]
        public global::System.DateTime? NextRunAt { get; set; }

        /// <summary>
        /// When the monitor was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the monitor was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The secret used to verify webhook signatures. This is only returned once at creation time. Store it securely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchMonitorResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the monitor
        /// </param>
        /// <param name="status">
        /// The status of the monitor. `active` monitors run on schedule and can be triggered manually. `paused` monitors can only be triggered manually. `disabled` monitors are auto-disabled after 10 consecutive authentication failures.
        /// </param>
        /// <param name="search"></param>
        /// <param name="webhook"></param>
        /// <param name="createdAt">
        /// When the monitor was created
        /// </param>
        /// <param name="updatedAt">
        /// When the monitor was last updated
        /// </param>
        /// <param name="webhookSecret">
        /// The secret used to verify webhook signatures. This is only returned once at creation time. Store it securely.
        /// </param>
        /// <param name="name">
        /// An optional display name
        /// </param>
        /// <param name="trigger">
        /// The interval-based schedule for automatic runs. Null if no schedule is set.
        /// </param>
        /// <param name="outputSchema">
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </param>
        /// <param name="metadata">
        /// Optional key-value metadata for your own tracking. Echoed back in webhook deliveries so you can route updates to systems like Slack.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </param>
        /// <param name="nextRunAt">
        /// When the next scheduled run will occur. Null if no trigger is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSearchMonitorResponse(
            string id,
            global::Exa.CreateSearchMonitorResponseStatus status,
            global::Exa.SearchMonitorSearchOutput search,
            global::Exa.SearchMonitorWebhookOutput webhook,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string webhookSecret,
            string? name,
            global::Exa.SearchMonitorTriggerOutput? trigger,
            global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant1, global::Exa.SearchMonitorOutputSchemaOutputVariant1Variant2>? outputSchema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? nextRunAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Status = status;
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.Trigger = trigger;
            this.OutputSchema = outputSchema;
            this.Metadata = metadata;
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
            this.NextRunAt = nextRunAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.WebhookSecret = webhookSecret ?? throw new global::System.ArgumentNullException(nameof(webhookSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchMonitorResponse" /> class.
        /// </summary>
        public CreateSearchMonitorResponse()
        {
        }

    }
}