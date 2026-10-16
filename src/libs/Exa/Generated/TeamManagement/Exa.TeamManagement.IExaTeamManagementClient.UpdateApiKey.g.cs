#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Update API key<br/>
        /// Updates an existing API key's name and/or rate limit. Only API keys belonging to the authenticated team can be updated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X PUT 'https://admin-api.exa.ai/team-management/api-keys/{id}' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "name": "Updated Production Key",<br/>
        ///     "rateLimit": 2000<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.UpdateApiKeyResponse> UpdateApiKeyAsync(
            string id,

            global::Exa.TeamManagement.UpdateApiKeyRequest request,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update API key<br/>
        /// Updates an existing API key's name and/or rate limit. Only API keys belonging to the authenticated team can be updated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X PUT 'https://admin-api.exa.ai/team-management/api-keys/{id}' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "name": "Updated Production Key",<br/>
        ///     "rateLimit": 2000<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.UpdateApiKeyResponse>> UpdateApiKeyAsResponseAsync(
            string id,

            global::Exa.TeamManagement.UpdateApiKeyRequest request,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update API key<br/>
        /// Updates an existing API key's name and/or rate limit. Only API keys belonging to the authenticated team can be updated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// Optional new name for the API key<br/>
        /// Example: Updated Production Key
        /// </param>
        /// <param name="rateLimit">
        /// Optional new rate limit for the API key (requests per second)<br/>
        /// Example: 2000
        /// </param>
        /// <param name="budgetCents">
        /// Optional new spending budget for the API key in the team's current billing period, in cents. It resets when the next billing period starts. Set to null to remove the budget.<br/>
        /// Example: 5000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.UpdateApiKeyResponse> UpdateApiKeyAsync(
            string id,
            string? name = default,
            int? rateLimit = default,
            int? budgetCents = default,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}