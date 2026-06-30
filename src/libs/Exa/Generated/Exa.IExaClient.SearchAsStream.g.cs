#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Search<br/>
        /// Perform a search with an Exa prompt-engineered query and retrieve a list of relevant results. Optionally get contents.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/search' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "query": "Latest research in LLMs",<br/>
        ///     "contents": {<br/>
        ///       "highlights": true<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.SearchStreamChunk> SearchAsStreamAsync(

            global::Exa.SearchRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search<br/>
        /// Perform a search with an Exa prompt-engineered query and retrieve a list of relevant results. Optionally get contents.
        /// </summary>
        /// <param name="includeDomains"></param>
        /// <param name="excludeDomains"></param>
        /// <param name="startCrawlDate"></param>
        /// <param name="endCrawlDate"></param>
        /// <param name="startPublishedDate"></param>
        /// <param name="endPublishedDate"></param>
        /// <param name="numResults"></param>
        /// <param name="context"></param>
        /// <param name="moderation"></param>
        /// <param name="contents"></param>
        /// <param name="query">
        /// The query string for the search.<br/>
        /// Example: Latest developments in LLM capabilities
        /// </param>
        /// <param name="additionalQueries"></param>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <param name="userLocation"></param>
        /// <param name="compliance"></param>
        /// <param name="outputSchema"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.SearchStreamChunk> SearchAsStreamAsync(
            string query,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::System.DateTime? startCrawlDate = default,
            global::System.DateTime? endCrawlDate = default,
            global::System.DateTime? startPublishedDate = default,
            global::System.DateTime? endPublishedDate = default,
            int? numResults = default,
            global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>? context = default,
            bool? moderation = default,
            global::Exa.ContentsOptions? contents = default,
            global::System.Collections.Generic.IList<string>? additionalQueries = default,
            global::Exa.SearchRequestType2? type = default,
            global::Exa.SearchRequestCategory2? category = default,
            string? userLocation = default,
            global::Exa.SearchRequestCompliance2? compliance = default,
            global::Exa.OneOf<global::Exa.SearchRequestOutputSchemaVariant1, global::Exa.SearchRequestOutputSchemaVariant2>? outputSchema = default,
            string? systemPrompt = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}