#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Create a monitor<br/>
        /// Creates a Monitor that runs an Exa search on a schedule and sends new results to your webhook. Each run searches recent content and drops results that match what earlier runs already returned, so your webhook receives only new developments.<br/>
        /// The response includes a `webhookSecret` for verifying webhook signatures. It is returned only once, so store it securely.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.exa.ai/monitors \<br/>
        ///   -H "x-api-key: $EXA_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{ ... }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.CreateSearchMonitorResponse> CreateMonitorAsync(

            global::Exa.CreateSearchMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a monitor<br/>
        /// Creates a Monitor that runs an Exa search on a schedule and sends new results to your webhook. Each run searches recent content and drops results that match what earlier runs already returned, so your webhook receives only new developments.<br/>
        /// The response includes a `webhookSecret` for verifying webhook signatures. It is returned only once, so store it securely.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.exa.ai/monitors \<br/>
        ///   -H "x-api-key: $EXA_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{ ... }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.CreateSearchMonitorResponse>> CreateMonitorAsResponseAsync(

            global::Exa.CreateSearchMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a monitor<br/>
        /// Creates a Monitor that runs an Exa search on a schedule and sends new results to your webhook. Each run searches recent content and drops results that match what earlier runs already returned, so your webhook receives only new developments.<br/>
        /// The response includes a `webhookSecret` for verifying webhook signatures. It is returned only once, so store it securely.
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
        /// Optional key-value metadata. Echoed back in webhook deliveries so you can route updates to systems like Slack.
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
            global::Exa.SearchMonitorOutputSchemaVariant1? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}