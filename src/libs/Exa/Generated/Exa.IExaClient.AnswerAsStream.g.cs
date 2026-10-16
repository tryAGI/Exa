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
        /// curl -X POST https://api.exa.ai/answer \<br/>
        ///   -H "x-api-key: $EXA_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{"query":"&lt;query&gt;"}'
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
        /// Natural-language question or instructions for the request.
        /// </param>
        /// <param name="text">
        /// If true, returns full page text with default settings. If false, disables text return.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// The model used to generate the answer.<br/>
        /// Default Value: exa
        /// </param>
        /// <param name="systemPrompt">
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.
        /// </param>
        /// <param name="userLocation"></param>
        /// <param name="outputSchema">
        /// A [JSON Schema Draft 7](https://json-schema.org/draft-07) specification for the desired answer structure. When provided, the answer is returned as a structured object matching the schema instead of a plain string.
        /// </param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.AnswerStreamChunk> AnswerAsStreamAsync(
            string query,
            bool? text = default,
            global::Exa.AnswerRequestModel? model = default,
            string? systemPrompt = default,
            global::Exa.OneOf<string, global::Exa.AnswerRequestUserLocationVariant1Variant2, global::Exa.AnswerRequestUserLocationVariant1Variant3>? userLocation = default,
            global::Exa.AnswerRequestOutputSchema? outputSchema = default,
            string? userIdentifier = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}