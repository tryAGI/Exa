#nullable enable

namespace Exa
{
    public partial interface IResearchClient
    {
        /// <summary>
        /// List research requests<br/>
        /// Get a paginated list of research requests
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://api.exa.ai/research/v1?limit=10' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ListResearchResponseDto> ResearchControllerListResearchAsync(
            string? cursor = default,
            double? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List research requests<br/>
        /// Get a paginated list of research requests
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://api.exa.ai/research/v1?limit=10' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListResearchResponseDto>> ResearchControllerListResearchAsResponseAsync(
            string? cursor = default,
            double? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}