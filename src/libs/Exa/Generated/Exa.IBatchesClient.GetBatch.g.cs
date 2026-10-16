#nullable enable

namespace Exa
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Get a batch<br/>
        /// Retrieve a single batch by ID.
        /// </summary>
        /// <param name="id">
        /// Batch ID.
        /// </param>
        /// <param name="exaBeta">
        /// Required beta token for the Batch API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Batch> GetBatchAsync(
            string id,
            global::Exa.GetBatchExaBeta exaBeta,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a batch<br/>
        /// Retrieve a single batch by ID.
        /// </summary>
        /// <param name="id">
        /// Batch ID.
        /// </param>
        /// <param name="exaBeta">
        /// Required beta token for the Batch API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Batch>> GetBatchAsResponseAsync(
            string id,
            global::Exa.GetBatchExaBeta exaBeta,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}