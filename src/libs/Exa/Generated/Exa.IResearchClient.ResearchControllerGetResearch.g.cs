#nullable enable

namespace Exa
{
    public partial interface IResearchClient
    {
        /// <summary>
        /// Get a research request by id<br/>
        /// Retrieve research by ID. Add ?stream=true for real-time SSE updates.
        /// </summary>
        /// <param name="researchId"></param>
        /// <param name="stream"></param>
        /// <param name="events"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://api.exa.ai/research/v1/01jszdfs0052sg4jc552sg4jc5' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ResearchDtoClass> ResearchControllerGetResearchAsync(
            string researchId,
            string? stream = default,
            string? events = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a research request by id<br/>
        /// Retrieve research by ID. Add ?stream=true for real-time SSE updates.
        /// </summary>
        /// <param name="researchId"></param>
        /// <param name="stream"></param>
        /// <param name="events"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET 'https://api.exa.ai/research/v1/01jszdfs0052sg4jc552sg4jc5' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ResearchDtoClass>> ResearchControllerGetResearchAsResponseAsync(
            string researchId,
            string? stream = default,
            string? events = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}