#nullable enable

namespace Exa
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Delete a run<br/>
        /// Delete a stored Agent run.
        /// </summary>
        /// <param name="id">
        /// Agent run ID.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// from exa_py import Exa<br/>
        /// exa = Exa(api_key="YOUR_EXA_API_KEY")<br/>
        /// run_id = "agent_run_01j..."<br/>
        /// deleted = exa.agent.runs.delete(<br/>
        ///     run_id,<br/>
        /// )<br/>
        /// print(deleted)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.DeleteAgentRunResponse> DeleteAgentRunAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a run<br/>
        /// Delete a stored Agent run.
        /// </summary>
        /// <param name="id">
        /// Agent run ID.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// from exa_py import Exa<br/>
        /// exa = Exa(api_key="YOUR_EXA_API_KEY")<br/>
        /// run_id = "agent_run_01j..."<br/>
        /// deleted = exa.agent.runs.delete(<br/>
        ///     run_id,<br/>
        /// )<br/>
        /// print(deleted)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.DeleteAgentRunResponse>> DeleteAgentRunAsResponseAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}