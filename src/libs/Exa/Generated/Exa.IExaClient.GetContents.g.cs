#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Contents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
        global::System.Threading.Tasks.Task<global::Exa.ContentsResponse> GetContentsAsync(

            global::Exa.ContentsRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Contents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ContentsResponse>> GetContentsAsResponseAsync(

            global::Exa.ContentsRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Contents
        /// </summary>
        /// <param name="ids">
        /// Document IDs obtained from searches.<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </param>
        /// <param name="urls">
        /// URLs to crawl (backwards compatible with the `ids` parameter).<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </param>
        /// <param name="compliance"></param>
        /// <param name="text"></param>
        /// <param name="highlights"></param>
        /// <param name="summary"></param>
        /// <param name="extras"></param>
        /// <param name="context"></param>
        /// <param name="livecrawl"></param>
        /// <param name="livecrawlTimeout"></param>
        /// <param name="maxAgeHours"></param>
        /// <param name="subpages"></param>
        /// <param name="subpageTarget"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ContentsResponse> GetContentsAsync(
            global::System.Collections.Generic.IList<string>? ids = default,
            global::System.Collections.Generic.IList<string>? urls = default,
            global::Exa.ContentsRequestCompliance2? compliance = default,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>? text = default,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>? highlights = default,
            global::Exa.ContentsRequestSummary2? summary = default,
            global::Exa.ContentsRequestExtras2? extras = default,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>? context = default,
            global::Exa.ContentsRequestLivecrawl2? livecrawl = default,
            int? livecrawlTimeout = default,
            int? maxAgeHours = default,
            int? subpages = default,
            global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}