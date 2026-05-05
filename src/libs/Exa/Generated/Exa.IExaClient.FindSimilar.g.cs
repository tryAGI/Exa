#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Find similar links<br/>
        /// Find similar links to the link provided. Optionally get contents.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/findSimilar' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "url": "https://arxiv.org/abs/2307.06435",<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.FindSimilarResponse> FindSimilarAsync(

            global::Exa.AllOf<global::Exa.FindSimilarRequest2, global::Exa.CommonRequest> request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find similar links<br/>
        /// Find similar links to the link provided. Optionally get contents.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/findSimilar' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "url": "https://arxiv.org/abs/2307.06435",<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.FindSimilarResponse>> FindSimilarAsResponseAsync(

            global::Exa.AllOf<global::Exa.FindSimilarRequest2, global::Exa.CommonRequest> request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find similar links<br/>
        /// Find similar links to the link provided. Optionally get contents.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.FindSimilarResponse> FindSimilarAsync(
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}