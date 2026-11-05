#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Get team credits<br/>
        /// Returns the team's remaining prepaid credit balance in USD and the credits that expire. The balance can lag recent usage by up to 5 minutes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/credits' \<br/>
        ///   -H "x-api-key: $EXA_SERVICE_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.GetTeamCreditsResponse> GetTeamCreditsAsync(
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get team credits<br/>
        /// Returns the team's remaining prepaid credit balance in USD and the credits that expire. The balance can lag recent usage by up to 5 minutes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/credits' \<br/>
        ///   -H "x-api-key: $EXA_SERVICE_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.GetTeamCreditsResponse>> GetTeamCreditsAsResponseAsync(
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}