#nullable enable

namespace Exa
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// List all Items for a Webset<br/>
        /// Returns a list of Webset Items.<br/>
        /// You can paginate through the Items using the `cursor` parameter.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListWebsetItemResponse> WebsetsItemsListAsync(
            string webset,
            string? cursor = default,
            int? limit = default,
            string? sourceId = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all Items for a Webset<br/>
        /// Returns a list of Webset Items.<br/>
        /// You can paginate through the Items using the `cursor` parameter.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListWebsetItemResponse>> WebsetsItemsListAsResponseAsync(
            string webset,
            string? cursor = default,
            int? limit = default,
            string? sourceId = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}