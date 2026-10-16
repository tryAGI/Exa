#nullable enable

namespace Exa
{
    public partial interface IWebhooksAttemptsClient
    {
        /// <summary>
        /// List webhook attempts<br/>
        /// List all attempts made by a Webhook ordered in descending order.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="successful"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListWebhookAttemptsResponse> WebhooksAttemptsListAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Exa.EventType? eventType = default,
            bool? successful = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook attempts<br/>
        /// List all attempts made by a Webhook ordered in descending order.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="successful"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListWebhookAttemptsResponse>> WebhooksAttemptsListAsResponseAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Exa.EventType? eventType = default,
            bool? successful = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}