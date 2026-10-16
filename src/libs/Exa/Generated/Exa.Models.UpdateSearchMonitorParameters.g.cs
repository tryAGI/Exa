
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateSearchMonitorParameters
    {
        /// <summary>
        /// Update the monitor name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Update the monitor status (can only set to `active` or `paused`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.UpdateSearchMonitorParametersStatusJsonConverter))]
        public global::Exa.UpdateSearchMonitorParametersStatus? Status { get; set; }

        /// <summary>
        /// Partial search params to merge. All fields are optional for updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::Exa.UpdateSearchMonitorParametersSearch? Search { get; set; }

        /// <summary>
        /// Update the schedule. Set to null to remove the schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::Exa.UpdateSearchMonitorParametersTrigger? Trigger { get; set; }

        /// <summary>
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::Exa.SearchMonitorOutputSchemaVariant1? OutputSchema { get; set; }

        /// <summary>
        /// Update metadata. Set to null to remove. Echoed back in webhook deliveries so you can route updates to systems like Slack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Partial webhook params to merge. All fields are optional for updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::Exa.UpdateSearchMonitorParametersWebhook? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// Update the monitor name
        /// </param>
        /// <param name="status">
        /// Update the monitor status (can only set to `active` or `paused`)
        /// </param>
        /// <param name="search">
        /// Partial search params to merge. All fields are optional for updates.
        /// </param>
        /// <param name="trigger">
        /// Update the schedule. Set to null to remove the schedule.
        /// </param>
        /// <param name="outputSchema">
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </param>
        /// <param name="metadata">
        /// Update metadata. Set to null to remove. Echoed back in webhook deliveries so you can route updates to systems like Slack.
        /// </param>
        /// <param name="webhook">
        /// Partial webhook params to merge. All fields are optional for updates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSearchMonitorParameters(
            string? name,
            global::Exa.UpdateSearchMonitorParametersStatus? status,
            global::Exa.UpdateSearchMonitorParametersSearch? search,
            global::Exa.UpdateSearchMonitorParametersTrigger? trigger,
            global::Exa.SearchMonitorOutputSchemaVariant1? outputSchema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::Exa.UpdateSearchMonitorParametersWebhook? webhook)
        {
            this.Name = name;
            this.Status = status;
            this.Search = search;
            this.Trigger = trigger;
            this.OutputSchema = outputSchema;
            this.Metadata = metadata;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParameters" /> class.
        /// </summary>
        public UpdateSearchMonitorParameters()
        {
        }

    }
}