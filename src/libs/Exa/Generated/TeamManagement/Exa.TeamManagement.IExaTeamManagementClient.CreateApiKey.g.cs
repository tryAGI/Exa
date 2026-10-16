#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Create API key<br/>
        /// Creates a new API key for the authenticated team. Optionally specify a name, rate limit, and budget for the API key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://admin-api.exa.ai/team-management/api-keys' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "name": "Production API Key",<br/>
        ///     "rateLimit": 1000<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.CreateApiKeyResponse> CreateApiKeyAsync(

            global::Exa.TeamManagement.CreateApiKeyRequest request,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API key<br/>
        /// Creates a new API key for the authenticated team. Optionally specify a name, rate limit, and budget for the API key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://admin-api.exa.ai/team-management/api-keys' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "name": "Production API Key",<br/>
        ///     "rateLimit": 1000<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.CreateApiKeyResponse>> CreateApiKeyAsResponseAsync(

            global::Exa.TeamManagement.CreateApiKeyRequest request,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API key<br/>
        /// Creates a new API key for the authenticated team. Optionally specify a name, rate limit, and budget for the API key.
        /// </summary>
        /// <param name="name">
        /// Optional name for the API key<br/>
        /// Example: Production API Key
        /// </param>
        /// <param name="rateLimit">
        /// Optional rate limit for the API key (requests per second)<br/>
        /// Example: 1000
        /// </param>
        /// <param name="budgetCents">
        /// Optional spending budget for the API key in the team's current billing period, in cents. It resets when the next billing period starts. Set to null to remove the budget.<br/>
        /// Example: 5000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.CreateApiKeyResponse> CreateApiKeyAsync(
            string? name = default,
            int? rateLimit = default,
            int? budgetCents = default,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}