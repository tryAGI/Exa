#nullable enable

namespace Exa
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// Delete an Item<br/>
        /// Deletes an Item from the Webset.<br/>
        /// This will cancel any enrichment process for it.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.WebsetItem> WebsetsItemsDeleteAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an Item<br/>
        /// Deletes an Item from the Webset.<br/>
        /// This will cancel any enrichment process for it.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetItem>> WebsetsItemsDeleteAsResponseAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}