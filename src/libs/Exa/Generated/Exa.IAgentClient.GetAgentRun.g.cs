#nullable enable

namespace Exa
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Get a run<br/>
        /// Retrieve a single Agent run by ID.
        /// </summary>
        /// <param name="id">
        /// Agent run ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://api.exa.ai/agent/runs/&lt;id&gt; \<br/>
        ///   -H "x-api-key: $EXA_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AgentRun> GetAgentRunAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a run<br/>
        /// Retrieve a single Agent run by ID.
        /// </summary>
        /// <param name="id">
        /// Agent run ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://api.exa.ai/agent/runs/&lt;id&gt; \<br/>
        ///   -H "x-api-key: $EXA_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.AgentRun>> GetAgentRunAsResponseAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}