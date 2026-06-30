#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Find similar links<br/>
        /// Find links similar to the provided URL and optionally retrieve their contents. Deprecated: prefer `/search` with a query describing the source.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::Exa.FindSimilarResponse> FindSimilarAsync(

            global::Exa.FindSimilarRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find similar links<br/>
        /// Find links similar to the provided URL and optionally retrieve their contents. Deprecated: prefer `/search` with a query describing the source.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.FindSimilarResponse>> FindSimilarAsResponseAsync(

            global::Exa.FindSimilarRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find similar links<br/>
        /// Find links similar to the provided URL and optionally retrieve their contents. Deprecated: prefer `/search` with a query describing the source.
        /// </summary>
        /// <param name="includeDomains"></param>
        /// <param name="excludeDomains"></param>
        /// <param name="startCrawlDate"></param>
        /// <param name="endCrawlDate"></param>
        /// <param name="startPublishedDate"></param>
        /// <param name="endPublishedDate"></param>
        /// <param name="numResults"></param>
        /// <param name="contents"></param>
        /// <param name="url">
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </param>
        /// <param name="category"></param>
        /// <param name="excludeSourceDomain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::Exa.FindSimilarResponse> FindSimilarAsync(
            string url,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::System.DateTime? startCrawlDate = default,
            global::System.DateTime? endCrawlDate = default,
            global::System.DateTime? startPublishedDate = default,
            global::System.DateTime? endPublishedDate = default,
            int? numResults = default,
            global::Exa.ContentsOptions? contents = default,
            global::Exa.FindSimilarRequestCategory2? category = default,
            bool? excludeSourceDomain = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}