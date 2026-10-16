#nullable enable

namespace Exa
{
    public partial interface IWebsetsClient
    {
        /// <summary>
        /// Update a Webset<br/>
        /// Updates the `title` or `metadata` of a Webset. Searches, imports, and enrichments are managed through their own endpoints.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Webset> WebsetsUpdateAsync(
            string id,

            global::Exa.UpdateWebsetRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Webset<br/>
        /// Updates the `title` or `metadata` of a Webset. Searches, imports, and enrichments are managed through their own endpoints.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Webset>> WebsetsUpdateAsResponseAsync(
            string id,

            global::Exa.UpdateWebsetRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Webset<br/>
        /// Updates the `title` or `metadata` of a Webset. Searches, imports, and enrichments are managed through their own endpoints.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="title">
        /// Optional name that appears anywhere the Webset is displayed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Webset> WebsetsUpdateAsync(
            string id,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? title = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}