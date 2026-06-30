#nullable enable

namespace Exa
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// List Runs<br/>
        /// Lists all runs for a monitor with cursor-based pagination. Runs are returned in reverse chronological order.
        /// </summary>
        /// <param name="id">
        /// The monitor ID
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response
        /// </param>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListSearchMonitorRunsResponse> ListRunsAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Runs<br/>
        /// Lists all runs for a monitor with cursor-based pagination. Runs are returned in reverse chronological order.
        /// </summary>
        /// <param name="id">
        /// The monitor ID
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response
        /// </param>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListSearchMonitorRunsResponse>> ListRunsAsResponseAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}