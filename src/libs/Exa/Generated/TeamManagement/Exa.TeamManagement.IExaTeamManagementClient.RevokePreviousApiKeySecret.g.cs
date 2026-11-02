#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Revoke previous API key secret<br/>
        /// Ends a rotation's grace period early. The secret replaced by the last rotation stops working now; the current secret is unaffected. Responds with `revoked` set to false when there is no previous secret in its grace period.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://admin-api.exa.ai/team-management/api-keys/{id}/revoke-previous' \<br/>
        ///   -H "x-api-key: $EXA_SERVICE_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse> RevokePreviousApiKeySecretAsync(
            string id,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke previous API key secret<br/>
        /// Ends a rotation's grace period early. The secret replaced by the last rotation stops working now; the current secret is unaffected. Responds with `revoked` set to false when there is no previous secret in its grace period.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://admin-api.exa.ai/team-management/api-keys/{id}/revoke-previous' \<br/>
        ///   -H "x-api-key: $EXA_SERVICE_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.RevokePreviousApiKeySecretResponse>> RevokePreviousApiKeySecretAsResponseAsync(
            string id,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}