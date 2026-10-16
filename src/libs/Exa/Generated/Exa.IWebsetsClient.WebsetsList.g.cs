#nullable enable

namespace Exa
{
    public partial interface IWebsetsClient
    {
        /// <summary>
        /// List all Websets<br/>
        /// Returns a list of Websets.<br/>
        /// You can paginate through the results using the `cursor` parameter.<br/>
        /// You can filter results using the `search` parameter to find Websets by ID, external ID, or title.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListWebsetsResponse> WebsetsListAsync(
            string? cursor = default,
            double? limit = default,
            string? search = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all Websets<br/>
        /// Returns a list of Websets.<br/>
        /// You can paginate through the results using the `cursor` parameter.<br/>
        /// You can filter results using the `search` parameter to find Websets by ID, external ID, or title.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListWebsetsResponse>> WebsetsListAsResponseAsync(
            string? cursor = default,
            double? limit = default,
            string? search = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}