#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// List API keys<br/>
        /// Returns the authenticated team's API keys. Pass `api_key_id` to return a single key.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/api-keys' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.OneOf<global::Exa.TeamManagement.ListApiKeysResponseVariant1, global::Exa.TeamManagement.ListApiKeysResponseVariant2>> ListApiKeysAsync(
            string? apiKeyId = default,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List API keys<br/>
        /// Returns the authenticated team's API keys. Pass `api_key_id` to return a single key.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/api-keys' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.OneOf<global::Exa.TeamManagement.ListApiKeysResponseVariant1, global::Exa.TeamManagement.ListApiKeysResponseVariant2>>> ListApiKeysAsResponseAsync(
            string? apiKeyId = default,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}