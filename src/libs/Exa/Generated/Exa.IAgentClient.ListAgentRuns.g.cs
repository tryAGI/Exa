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
        /// Cursor for pagination. Use the `nextCursor` value from the previous run list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://api.exa.ai/agent/runs \<br/>
        ///   -H "x-api-key: $EXA_API_KEY"
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
        /// Cursor for pagination. Use the `nextCursor` value from the previous run list response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://api.exa.ai/agent/runs \<br/>
        ///   -H "x-api-key: $EXA_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.AgentRunList>> ListAgentRunsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}