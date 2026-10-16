#nullable enable

namespace Exa
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Cancel a run<br/>
        /// Cancel a queued or running Agent run immediately without returning any results. You are billed for usage accrued before cancellation. If the run has already reached a terminal status, the API returns the existing run.
        /// </summary>
        /// <param name="id">
        /// Agent run ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.exa.ai/agent/runs/&lt;id&gt;/cancel \<br/>
        ///   -H "x-api-key: $EXA_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AgentRun> CancelAgentRunAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a run<br/>
        /// Cancel a queued or running Agent run immediately without returning any results. You are billed for usage accrued before cancellation. If the run has already reached a terminal status, the API returns the existing run.
        /// </summary>
        /// <param name="id">
        /// Agent run ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://api.exa.ai/agent/runs/&lt;id&gt;/cancel \<br/>
        ///   -H "x-api-key: $EXA_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.AgentRun>> CancelAgentRunAsResponseAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}