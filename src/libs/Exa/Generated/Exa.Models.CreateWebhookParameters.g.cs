
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookParameters
    {
        /// <summary>
        /// The events to trigger the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.EventType> Events { get; set; }

        /// <summary>
        /// The URL to send the webhook to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookParameters" /> class.
        /// </summary>
        /// <param name="events">
        /// The events to trigger the webhook
        /// </param>
        /// <param name="url">
        /// The URL to send the webhook to
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookParameters(
            global::System.Collections.Generic.IList<global::Exa.EventType> events,
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookParameters" /> class.
        /// </summary>
        public CreateWebhookParameters()
        {
        }

    }
}