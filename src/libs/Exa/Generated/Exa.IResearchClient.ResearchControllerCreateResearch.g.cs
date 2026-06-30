#nullable enable

namespace Exa
{
    public partial interface IResearchClient
    {
        /// <summary>
        /// Create a new research request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/research/v1' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "instructions": "Summarize the latest developments in AI safety research",<br/>
        ///     "model": "exa-research"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ResearchDtoClass> ResearchControllerCreateResearchAsync(

            global::Exa.ResearchCreateRequestDtoClass request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new research request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/research/v1' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "instructions": "Summarize the latest developments in AI safety research",<br/>
        ///     "model": "exa-research"<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ResearchDtoClass>> ResearchControllerCreateResearchAsResponseAsync(

            global::Exa.ResearchCreateRequestDtoClass request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new research request
        /// </summary>
        /// <param name="model">
        /// Research model to use. exa-research is faster and cheaper, while exa-research-pro provides more thorough analysis and stronger reasoning.<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="instructions">
        /// Instructions for what you would like research on. A good prompt clearly defines what information you want to find, how research should be conducted, and what the output should look like.
        /// </param>
        /// <param name="outputSchema">
        /// JSON Schema to enforce structured output. When provided, the research output will be validated against this schema and returned as parsed JSON.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ResearchDtoClass> ResearchControllerCreateResearchAsync(
            string instructions,
            global::Exa.ResearchCreateRequestDtoClassModel? model = default,
            object? outputSchema = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}