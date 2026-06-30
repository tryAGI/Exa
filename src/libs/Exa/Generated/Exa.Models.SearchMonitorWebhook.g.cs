
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMonitorWebhook
    {
        /// <summary>
        /// The HTTPS URL to receive webhook events. Must not point to localhost or private IP ranges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Which events to subscribe to. Defaults to all events if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorWebhook" /> class.
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
        public SearchMonitorWebhook(
            string url,
            global::System.Collections.Generic.IList<global::Exa.SearchMonitorWebhookEvent>? events)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorWebhook" /> class.
        /// </summary>
        public SearchMonitorWebhook()
        {
        }

    }
}