#nullable enable

namespace Exa
{
    public partial interface IWebsetsClient
    {
        /// <summary>
        /// Get a Webset<br/>
        /// Returns a Webset by `id` or `externalId`, including its status, searches, imports, enrichments, and monitors.<br/>
        /// Pass `expand=items` to include up to the first 100 items in the response.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.GetWebsetResponse> WebsetsGetAsync(
            string id,
            global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>? expand = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Webset<br/>
        /// Returns a Webset by `id` or `externalId`, including its status, searches, imports, enrichments, and monitors.<br/>
        /// Pass `expand=items` to include up to the first 100 items in the response.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.GetWebsetResponse>> WebsetsGetAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>? expand = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}