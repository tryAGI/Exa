
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Webhook
    {
        /// <summary>
        /// The unique identifier for the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: webhook
        /// </summary>
        /// <default>"webhook"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "webhook";

        /// <summary>
        /// The status of the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebhookStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebhookStatus Status { get; set; }

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
        /// The secret to verify the webhook signature. Only returned on Webhook creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// The metadata of the webhook<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The date and time the webhook was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the webhook was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the webhook
        /// </param>
        /// <param name="status">
        /// The status of the webhook
        /// </param>
        /// <param name="events">
        /// The events to trigger the webhook
        /// </param>
        /// <param name="url">
        /// The URL to send the webhook to
        /// </param>
        /// <param name="createdAt">
        /// The date and time the webhook was created
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the webhook was last updated
        /// </param>
        /// <param name="secret">
        /// The secret to verify the webhook signature. Only returned on Webhook creation.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the webhook<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="object">
        /// Default Value: webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Webhook(
            string id,
            global::Exa.WebhookStatus status,
            global::System.Collections.Generic.IList<global::Exa.EventType> events,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? secret,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string @object = "webhook")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Secret = secret;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        public Webhook()
        {
        }

    }
}