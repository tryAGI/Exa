#nullable enable

namespace Exa
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Get Team Info<br/>
        /// Returns information about the authenticated team, including current concurrency usage and limits.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://api.exa.ai/websets/v0/teams/me' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.WebsetsTeamInfo> TeamsMeGetAsync(
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Team Info<br/>
        /// Returns information about the authenticated team, including current concurrency usage and limits.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://api.exa.ai/websets/v0/teams/me' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetsTeamInfo>> TeamsMeGetAsResponseAsync(
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}