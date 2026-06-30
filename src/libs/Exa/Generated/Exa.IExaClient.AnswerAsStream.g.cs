#nullable enable

namespace Exa
{
    public partial interface IExaClient
    {
        /// <summary>
        /// Answer<br/>
        /// Performs a search based on the query and generates either a direct answer or a detailed summary with citations, depending on the query type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X POST 'https://api.exa.ai/answer' \<br/>
        ///   -H 'x-api-key: YOUR-EXA-API-KEY' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "query": "What is the latest valuation of SpaceX?",<br/>
        ///     "text": true<br/>
        ///   }'
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.AnswerStreamChunk> AnswerAsStreamAsync(

            global::Exa.AnswerRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Answer<br/>
        /// Performs a search based on the query and generates either a direct answer or a detailed summary with citations, depending on the query type.
        /// </summary>
        /// <param name="query">
        /// Natural-language question or instructions for the request.<br/>
        /// Example: What is the latest valuation of SpaceX?
        /// </param>
        /// <param name="text">
        /// If true, returns full page text with default settings. If false, disables text return.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputSchema">
        /// A [JSON Schema Draft 7](https://json-schema.org/draft-07) specification for the desired answer structure. When provided, the answer is returned as a structured object matching the schema instead of a plain string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.AnswerStreamChunk> AnswerAsStreamAsync(
            string query,
            bool? text = default,
            global::Exa.AnswerRequestOutputSchema? outputSchema = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}