#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Create a Monitor<br/>
        /// Creates a new Monitor to run recurring Exa searches on a schedule.<br/>
        /// Monitors automatically execute your search query on a recurring schedule and deliver results to your webhook endpoint with automatic deduplication:<br/>
        /// - **Date-based filtering** only fetches content since the last run<br/>
        /// - **Semantic deduplication** tracks previous outputs to surface only new developments<br/>
        /// The response includes a `webhookSecret` that is only returned once at creation time. Store it securely for webhook signature verification.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.CreateSearchMonitorResponse> CreateMonitorAsync(

            global::Exa.CreateSearchMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Monitor<br/>
        /// Creates a new Monitor to run recurring Exa searches on a schedule.<br/>
        /// Monitors automatically execute your search query on a recurring schedule and deliver results to your webhook endpoint with automatic deduplication:<br/>
        /// - **Date-based filtering** only fetches content since the last run<br/>
        /// - **Semantic deduplication** tracks previous outputs to surface only new developments<br/>
        /// The response includes a `webhookSecret` that is only returned once at creation time. Store it securely for webhook signature verification.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.CreateSearchMonitorResponse>> CreateMonitorAsResponseAsync(

            global::Exa.CreateSearchMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Monitor<br/>
        /// Creates a new Monitor to run recurring Exa searches on a schedule.<br/>
        /// Monitors automatically execute your search query on a recurring schedule and deliver results to your webhook endpoint with automatic deduplication:<br/>
        /// - **Date-based filtering** only fetches content since the last run<br/>
        /// - **Semantic deduplication** tracks previous outputs to surface only new developments<br/>
        /// The response includes a `webhookSecret` that is only returned once at creation time. Store it securely for webhook signature verification.
        /// </summary>
        /// <param name="name">
        /// An optional name for the monitor
        /// </param>
        /// <param name="search"></param>
        /// <param name="trigger"></param>
        /// <param name="outputSchema">
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </param>
        /// <param name="metadata">
        /// Optional key-value metadata. Echoed back in webhook deliveries so you can route updates to systems like Slack.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </param>
        /// <param name="webhook"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.CreateSearchMonitorResponse> CreateMonitorAsync(
            global::Exa.SearchMonitorSearch search,
            global::Exa.SearchMonitorWebhook webhook,
            string? name = default,
            global::Exa.SearchMonitorTrigger? trigger = default,
            global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}