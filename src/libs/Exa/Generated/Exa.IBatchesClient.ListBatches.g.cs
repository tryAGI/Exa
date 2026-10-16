#nullable enable

namespace Exa
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// List batches<br/>
        /// List batches for your team, ordered from newest to oldest.
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from a previous response
        /// </param>
        /// <param name="limit">
        /// Maximum number of batches to return per page. Defaults to 100 when omitted; there is no upper bound.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="status">
        /// Return only completed batches, ordered by expiry. Send it on every page request when paginating.
        /// </param>
        /// <param name="exaBeta">
        /// Required beta token for the Batch API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.BatchList> ListBatchesAsync(
            global::Exa.ListBatchesExaBeta exaBeta,
            string? cursor = default,
            int? limit = default,
            string? status = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List batches<br/>
        /// List batches for your team, ordered from newest to oldest.
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from a previous response
        /// </param>
        /// <param name="limit">
        /// Maximum number of batches to return per page. Defaults to 100 when omitted; there is no upper bound.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="status">
        /// Return only completed batches, ordered by expiry. Send it on every page request when paginating.
        /// </param>
        /// <param name="exaBeta">
        /// Required beta token for the Batch API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.BatchList>> ListBatchesAsResponseAsync(
            global::Exa.ListBatchesExaBeta exaBeta,
            string? cursor = default,
            int? limit = default,
            string? status = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}