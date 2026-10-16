#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Delete API key<br/>
        /// Deletes an API key. Only API keys belonging to the authenticated team can be deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X DELETE 'https://admin-api.exa.ai/team-management/api-keys/{id}' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.DeleteApiKeyResponse> DeleteApiKeyAsync(
            string id,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete API key<br/>
        /// Deletes an API key. Only API keys belonging to the authenticated team can be deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X DELETE 'https://admin-api.exa.ai/team-management/api-keys/{id}' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.DeleteApiKeyResponse>> DeleteApiKeyAsResponseAsync(
            string id,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}