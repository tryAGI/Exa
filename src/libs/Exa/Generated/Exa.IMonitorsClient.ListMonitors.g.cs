#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// List Monitors<br/>
        /// Lists all monitors for the authenticated team. Supports filtering by status and cursor-based pagination.
        /// </summary>
        /// <param name="status">
        /// Filter monitors by status
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response
        /// </param>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="name">
        /// Filter monitors by name (case-insensitive substring match)
        /// </param>
        /// <param name="metadata">
        /// Filter monitors by metadata key-value pairs (exact match, AND semantics). Use bracket notation: `metadata[key]=value`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListSearchMonitorsResponse> ListMonitorsAsync(
            global::Exa.ListMonitorsStatus? status = default,
            string? cursor = default,
            int? limit = default,
            string? name = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Monitors<br/>
        /// Lists all monitors for the authenticated team. Supports filtering by status and cursor-based pagination.
        /// </summary>
        /// <param name="status">
        /// Filter monitors by status
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response
        /// </param>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="name">
        /// Filter monitors by name (case-insensitive substring match)
        /// </param>
        /// <param name="metadata">
        /// Filter monitors by metadata key-value pairs (exact match, AND semantics). Use bracket notation: `metadata[key]=value`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListSearchMonitorsResponse>> ListMonitorsAsResponseAsync(
            global::Exa.ListMonitorsStatus? status = default,
            string? cursor = default,
            int? limit = default,
            string? name = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}