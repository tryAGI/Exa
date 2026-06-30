#nullable enable

namespace Exa
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Get a Run<br/>
        /// Retrieves a single run by its ID, including the full output if the run is completed.
        /// </summary>
        /// <param name="id">
        /// The monitor ID
        /// </param>
        /// <param name="runId">
        /// The run ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.SearchMonitorRun> GetRunAsync(
            string id,
            string runId,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Run<br/>
        /// Retrieves a single run by its ID, including the full output if the run is completed.
        /// </summary>
        /// <param name="id">
        /// The monitor ID
        /// </param>
        /// <param name="runId">
        /// The run ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.SearchMonitorRun>> GetRunAsResponseAsync(
            string id,
            string runId,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}