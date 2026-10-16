#nullable enable

namespace Exa
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Create a batch<br/>
        /// Create a batch of requests to run asynchronously. Each request is dispatched to its target route and results are made available for download when the batch completes.
        /// </summary>
        /// <param name="exaBeta">
        /// Required beta token for the Batch API.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Batch> CreateBatchAsync(
            global::Exa.CreateBatchExaBeta exaBeta,

            global::Exa.CreateBatchRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Create a batch of requests to run asynchronously. Each request is dispatched to its target route and results are made available for download when the batch completes.
        /// </summary>
        /// <param name="exaBeta">
        /// Required beta token for the Batch API.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Batch>> CreateBatchAsResponseAsync(
            global::Exa.CreateBatchExaBeta exaBeta,

            global::Exa.CreateBatchRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Create a batch of requests to run asynchronously. Each request is dispatched to its target route and results are made available for download when the batch completes.
        /// </summary>
        /// <param name="exaBeta">
        /// Required beta token for the Batch API.
        /// </param>
        /// <param name="requests">
        /// The requests to enqueue. Each `customId` must be unique within the batch.
        /// </param>
        /// <param name="metadata">
        /// Caller-provided metadata stored with the batch.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Batch> CreateBatchAsync(
            global::Exa.CreateBatchExaBeta exaBeta,
            global::System.Collections.Generic.IList<global::Exa.BatchRequestItem> requests,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}