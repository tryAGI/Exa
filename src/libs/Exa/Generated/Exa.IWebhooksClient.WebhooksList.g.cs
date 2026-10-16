#nullable enable

namespace Exa
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List webhooks<br/>
        /// Returns the active Webhooks for your team.<br/>
        /// You can paginate through the results using the `cursor` parameter.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListWebhooksResponse> WebhooksListAsync(
            string? cursor = default,
            int? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhooks<br/>
        /// Returns the active Webhooks for your team.<br/>
        /// You can paginate through the results using the `cursor` parameter.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListWebhooksResponse>> WebhooksListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}