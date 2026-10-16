#nullable enable

namespace Exa
{
    public partial interface IWebsetsClient
    {
        /// <summary>
        /// Cancel a running Webset<br/>
        /// Cancels all operations being performed on a Webset.<br/>
        /// Any enrichment or search will be stopped and the Webset will be marked as `idle`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Webset> WebsetsCancelAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a running Webset<br/>
        /// Cancels all operations being performed on a Webset.<br/>
        /// Any enrichment or search will be stopped and the Webset will be marked as `idle`.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Webset>> WebsetsCancelAsResponseAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}