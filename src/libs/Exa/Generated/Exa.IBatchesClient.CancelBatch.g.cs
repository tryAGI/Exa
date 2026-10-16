#nullable enable

namespace Exa
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Cancel a batch<br/>
        /// Request cancellation of a batch. The batch stops scheduling new requests and drains in-flight work before settling to `cancelled`. Cancelling a batch that is already `cancelling` or `cancelled` is idempotent and returns the batch unchanged. A batch that has already reached a terminal status (`completed` or `expired`) cannot be cancelled and the request fails with a 409.
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
        global::System.Threading.Tasks.Task<global::Exa.Batch> CancelBatchAsync(
            string id,
            global::Exa.CancelBatchExaBeta exaBeta,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a batch<br/>
        /// Request cancellation of a batch. The batch stops scheduling new requests and drains in-flight work before settling to `cancelled`. Cancelling a batch that is already `cancelling` or `cancelled` is idempotent and returns the batch unchanged. A batch that has already reached a terminal status (`completed` or `expired`) cannot be cancelled and the request fails with a 409.
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
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Batch>> CancelBatchAsResponseAsync(
            string id,
            global::Exa.CancelBatchExaBeta exaBeta,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}