
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookAttempt
    {
        /// <summary>
        /// The unique identifier for the webhook attempt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: webhook_attempt
        /// </summary>
        /// <default>"webhook_attempt"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "webhook_attempt";

        /// <summary>
        /// The unique identifier for the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The type of event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebhookAttemptEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebhookAttemptEventType EventType { get; set; }

        /// <summary>
        /// The unique identifier for the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookId { get; set; }

        /// <summary>
        /// The URL that was used during the attempt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Whether the attempt was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Successful { get; set; }

        /// <summary>
        /// The headers of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseHeaders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ResponseHeaders { get; set; }

        /// <summary>
        /// The body of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBody")]
        public string? ResponseBody { get; set; }

        /// <summary>
        /// The status code of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseStatusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseStatusCode { get; set; }

        /// <summary>
        /// The attempt number of the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Attempt { get; set; }

        /// <summary>
        /// The date and time the webhook attempt was made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attemptedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AttemptedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAttempt" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the webhook attempt
        /// </param>
        /// <param name="eventId">
        /// The unique identifier for the event
        /// </param>
        /// <param name="eventType">
        /// The type of event
        /// </param>
        /// <param name="webhookId">
        /// The unique identifier for the webhook
        /// </param>
        /// <param name="url">
        /// The URL that was used during the attempt
        /// </param>
        /// <param name="successful">
        /// Whether the attempt was successful
        /// </param>
        /// <param name="responseHeaders">
        /// The headers of the response
        /// </param>
        /// <param name="responseStatusCode">
        /// The status code of the response
        /// </param>
        /// <param name="attempt">
        /// The attempt number of the webhook
        /// </param>
        /// <param name="attemptedAt">
        /// The date and time the webhook attempt was made
        /// </param>
        /// <param name="responseBody">
        /// The body of the response
        /// </param>
        /// <param name="object">
        /// Default Value: webhook_attempt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAttempt(
            string id,
            string eventId,
            global::Exa.WebhookAttemptEventType eventType,
            string webhookId,
            string url,
            bool successful,
            global::System.Collections.Generic.Dictionary<string, string> responseHeaders,
            double responseStatusCode,
            double attempt,
            global::System.DateTime attemptedAt,
            string? responseBody,
            string @object = "webhook_attempt")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.EventType = eventType;
            this.WebhookId = webhookId ?? throw new global::System.ArgumentNullException(nameof(webhookId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Successful = successful;
            this.ResponseHeaders = responseHeaders ?? throw new global::System.ArgumentNullException(nameof(responseHeaders));
            this.ResponseBody = responseBody;
            this.ResponseStatusCode = responseStatusCode;
            this.Attempt = attempt;
            this.AttemptedAt = attemptedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAttempt" /> class.
        /// </summary>
        public WebhookAttempt()
        {
        }

    }
}