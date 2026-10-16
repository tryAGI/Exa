#nullable enable

namespace Exa
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Delete a batch<br/>
        /// Soft-delete a batch in a terminal status.
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
        global::System.Threading.Tasks.Task<global::Exa.DeletedBatch> DeleteBatchAsync(
            string id,
            global::Exa.DeleteBatchExaBeta exaBeta,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a batch<br/>
        /// Soft-delete a batch in a terminal status.
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
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.DeletedBatch>> DeleteBatchAsResponseAsync(
            string id,
            global::Exa.DeleteBatchExaBeta exaBeta,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}