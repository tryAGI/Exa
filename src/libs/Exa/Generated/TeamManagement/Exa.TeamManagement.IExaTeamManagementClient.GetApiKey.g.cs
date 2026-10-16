#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Get API key<br/>
        /// Retrieves details of a specific API key by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/api-keys/{id}' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.GetApiKeyResponse> GetApiKeyAsync(
            string id,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get API key<br/>
        /// Retrieves details of a specific API key by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/api-keys/{id}' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.GetApiKeyResponse>> GetApiKeyAsResponseAsync(
            string id,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}