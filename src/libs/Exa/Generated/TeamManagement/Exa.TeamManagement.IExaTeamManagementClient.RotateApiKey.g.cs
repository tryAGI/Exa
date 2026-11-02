#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Rotate API key<br/>
        /// Replaces an API key's secret and returns the new one. The key keeps its `publicId`, name, rate limit, budget, and usage history. The old secret keeps working for `gracePeriodSeconds` (0 revokes it immediately), so the new secret can be rolled out before the old one stops working. A key has at most one previous secret: while it is still in its grace period, rotation returns 409 unless `force` is true.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://admin-api.exa.ai/team-management/api-keys/{id}/rotate' \<br/>
        ///   -H "x-api-key: $EXA_SERVICE_KEY" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "gracePeriodSeconds": 86400<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.RotateApiKeyResponse> RotateApiKeyAsync(
            string id,

            global::Exa.TeamManagement.RotateApiKeyRequest request,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate API key<br/>
        /// Replaces an API key's secret and returns the new one. The key keeps its `publicId`, name, rate limit, budget, and usage history. The old secret keeps working for `gracePeriodSeconds` (0 revokes it immediately), so the new secret can be rolled out before the old one stops working. A key has at most one previous secret: while it is still in its grace period, rotation returns 409 unless `force` is true.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://admin-api.exa.ai/team-management/api-keys/{id}/rotate' \<br/>
        ///   -H "x-api-key: $EXA_SERVICE_KEY" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "gracePeriodSeconds": 86400<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.RotateApiKeyResponse>> RotateApiKeyAsResponseAsync(
            string id,

            global::Exa.TeamManagement.RotateApiKeyRequest request,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate API key<br/>
        /// Replaces an API key's secret and returns the new one. The key keeps its `publicId`, name, rate limit, budget, and usage history. The old secret keeps working for `gracePeriodSeconds` (0 revokes it immediately), so the new secret can be rolled out before the old one stops working. A key has at most one previous secret: while it is still in its grace period, rotation returns 409 unless `force` is true.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gracePeriodSeconds">
        /// How long the old secret keeps working, in seconds (at most 90 days). 0 revokes it immediately.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="force">
        /// Rotate even if the secret replaced by an earlier rotation is still in its grace period. That secret stops working immediately.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.RotateApiKeyResponse> RotateApiKeyAsync(
            string id,
            int gracePeriodSeconds,
            bool? force = default,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}