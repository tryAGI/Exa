#nullable enable

namespace Exa
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// List runs<br/>
        /// List Agent runs for your team, ordered from newest to oldest.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination. Use the `nextCursor` value from the previous run list response.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// from exa_py import Exa<br/>
        /// exa = Exa(api_key="YOUR_EXA_API_KEY")<br/>
        /// runs = exa.agent.runs.list(<br/>
        ///     limit=10,<br/>
        /// )<br/>
        /// print(runs)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AgentRunList> ListAgentRunsAsync(
            int? limit = default,
            string? cursor = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List runs<br/>
        /// List Agent runs for your team, ordered from newest to oldest.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination. Use the `nextCursor` value from the previous run list response.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// from exa_py import Exa<br/>
        /// exa = Exa(api_key="YOUR_EXA_API_KEY")<br/>
        /// runs = exa.agent.runs.list(<br/>
        ///     limit=10,<br/>
        /// )<br/>
        /// print(runs)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.AgentRunList>> ListAgentRunsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}