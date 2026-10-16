#nullable enable

namespace Exa.TeamManagement
{
    public partial interface IExaTeamManagementClient
    {
        /// <summary>
        /// Get API key usage<br/>
        /// Returns an API key's cost over a time period, in total and by price.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="groupBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/api-keys/{id}/usage' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.GetApiKeyUsageResponse> GetApiKeyUsageAsync(
            string id,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Exa.TeamManagement.GetApiKeyUsageGroupBy? groupBy = default,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get API key usage<br/>
        /// Returns an API key's cost over a time period, in total and by price.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="groupBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.TeamManagement.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://admin-api.exa.ai/team-management/api-keys/{id}/usage' \<br/>
        ///   -H 'x-api-key: YOUR-SERVICE-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.TeamManagement.AutoSDKHttpResponse<global::Exa.TeamManagement.GetApiKeyUsageResponse>> GetApiKeyUsageAsResponseAsync(
            string id,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Exa.TeamManagement.GetApiKeyUsageGroupBy? groupBy = default,
            global::Exa.TeamManagement.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}