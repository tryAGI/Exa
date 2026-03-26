#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Get Contents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/contents' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "urls": ["https://arxiv.org/abs/2307.06435"],<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.GetContentsResponse> GetContentsAsync(

            global::Exa.AllOf<global::Exa.GetContentsRequest2, global::Exa.ContentsRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Contents
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.GetContentsResponse> GetContentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}