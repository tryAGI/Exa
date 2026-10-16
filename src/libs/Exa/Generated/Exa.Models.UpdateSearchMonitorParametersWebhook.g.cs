
#nullable enable

namespace Exa
{
    /// <summary>
    /// Partial webhook params to merge. All fields are optional for updates.
    /// </summary>
    public sealed partial class UpdateSearchMonitorParametersWebhook
    {
        /// <summary>
        /// The HTTPS URL to receive webhook events. Must not point to localhost or private IP ranges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Which events to subscribe to. Defaults to all events if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Exa.UpdateSearchMonitorParametersWebhookEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParametersWebhook" /> class.
        /// </summary>
        /// <param name="url">
        /// The HTTPS URL to receive webhook events. Must not point to localhost or private IP ranges.
        /// </param>
        /// <param name="events">
        /// Which events to subscribe to. Defaults to all events if not specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSearchMonitorParametersWebhook(
            string? url,
            global::System.Collections.Generic.IList<global::Exa.UpdateSearchMonitorParametersWebhookEvent>? events)
        {
            this.Url = url;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParametersWebhook" /> class.
        /// </summary>
        public UpdateSearchMonitorParametersWebhook()
        {
        }

    }
}