#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Batch action on monitors<br/>
        /// Deletes, pauses, or unpauses the monitors that match the filter. Deletion is permanent. `dry_run` defaults to `true`, so a request only previews the affected monitors unless you set it to `false`. Repeat the request until `has_more` is `false` to process all matches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.BatchMonitorsResponse> BatchMonitorsAsync(

            global::Exa.BatchMonitorsRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch action on monitors<br/>
        /// Deletes, pauses, or unpauses the monitors that match the filter. Deletion is permanent. `dry_run` defaults to `true`, so a request only previews the affected monitors unless you set it to `false`. Repeat the request until `has_more` is `false` to process all matches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.BatchMonitorsResponse>> BatchMonitorsAsResponseAsync(

            global::Exa.BatchMonitorsRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch action on monitors<br/>
        /// Deletes, pauses, or unpauses the monitors that match the filter. Deletion is permanent. `dry_run` defaults to `true`, so a request only previews the affected monitors unless you set it to `false`. Repeat the request until `has_more` is `false` to process all matches.
        /// </summary>
        /// <param name="action">
        /// The action to perform on matching monitors. `delete` permanently removes them, `pause` sets their status to paused, and `unpause` sets their status to active.
        /// </param>
        /// <param name="filter">
        /// At least one filter field must be provided to prevent accidental bulk operations.
        /// </param>
        /// <param name="dryRun">
        /// When `true`, returns the monitors that would be affected without performing the action. Defaults to `true`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Maximum number of monitors to process in a single request. Defaults to 50, maximum 500.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.BatchMonitorsResponse> BatchMonitorsAsync(
            global::Exa.BatchMonitorsRequestAction action,
            global::Exa.BatchMonitorsRequestFilter filter,
            bool? dryRun = default,
            int? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}