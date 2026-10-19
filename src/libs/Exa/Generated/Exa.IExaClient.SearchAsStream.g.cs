#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

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
        /// curl -X POST https://api.exa.ai/search \<br/>
        ///   -H "x-api-key: $EXA_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///   "query": "&lt;query&gt;",<br/>
        ///   "type": "auto",<br/>
        ///   "contents": {<br/>
        ///     "highlights": true<br/>
        ///   }<br/>
        /// }'
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
        /// <param name="startPublishedDate"></param>
        /// <param name="endPublishedDate"></param>
        /// <param name="numResults"></param>
        /// <param name="moderation"></param>
        /// <param name="contents"></param>
        /// <param name="query">
        /// The query string for the search.
        /// </param>
        /// <param name="additionalQueries"></param>
        /// <param name="type">
        /// The search mode to use. Defaults to `auto`, a balanced mode recommended for most applications.<br/>
        /// - `auto`: The default. A balanced mode that optimizes for both quality and speed and is recommended for most applications.<br/>
        /// - `lite`: Low-cost, low-latency search for real-time and interactive experiences such as chat, voice agents, and autocomplete. Accepts only `query` (a single string), `objective`, `userIdentifier`, `metadata`, `category`, `numResults`, `contents.highlights`, `contents.text`, `contents.snapshotAsOf`, `userLocation`, `includeDomains`, `excludeDomains`, `startPublishedDate`, `endPublishedDate`, `moderation`, and `compliance`; a request that sets any other parameter is rejected. Serves cached content only; it never fetches live, so the freshness options are rejected.<br/>
        /// - `deep-lite`: Performs lightweight research with synthesized results and a consistent 4-second latency, lower than full deep search.<br/>
        /// - `deep`: Conducts comprehensive multi-step research with synthesis.<br/>
        /// - `instant`: Legacy. Use `lite` instead. Runs a minimum-latency search that trades some search depth for speed. Unlike `lite`, it accepts every search parameter.<br/>
        /// - `fast`: Legacy. Use `lite` instead. Runs a reduced-latency search for user-facing and interactive workflows. Unlike `lite`, it accepts every search parameter.<br/>
        /// - `deep-reasoning`: Legacy. Use `deep` instead. Runs `deep` with stronger reasoning at each step, for complex analysis and decision-making tasks. For agentic, multi-step research, use the Agent API.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="category"></param>
        /// <param name="userLocation"></param>
        /// <param name="compliance"></param>
        /// <param name="outputSchema"></param>
        /// <param name="objective">
        /// The broader goal this search serves: the task the caller is working on, beyond the query itself. When exposing this field to an agent as a tool parameter, describe it as: "Goal for this search turn; say which documents should rank first, which should be excluded, and what specific facts or figures to pull from them."
        /// </param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
        /// <param name="systemPrompt"></param>
        /// <param name="startCrawlDate"></param>
        /// <param name="endCrawlDate"></param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.SearchStreamChunk> SearchAsStreamAsync(
            string query,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::System.DateTime? startPublishedDate = default,
            global::System.DateTime? endPublishedDate = default,
            int? numResults = default,
            bool? moderation = default,
            global::Exa.ContentsOptions? contents = default,
            global::System.Collections.Generic.IList<string>? additionalQueries = default,
            string? type = default,
            global::Exa.SearchRequestCategory? category = default,
            global::Exa.OneOf<string, global::Exa.SearchRequestUserLocationVariant1Variant2, global::Exa.SearchRequestUserLocationVariant1Variant3>? userLocation = default,
            global::Exa.SearchRequestCompliance? compliance = default,
            global::Exa.SearchRequestOutputSchema? outputSchema = default,
            string? objective = default,
            string? userIdentifier = default,
            string? systemPrompt = default,
            global::System.DateTime? startCrawlDate = default,
            global::System.DateTime? endCrawlDate = default,
            global::Exa.OneOf<bool?, global::Exa.SearchRequestContextVariant1>? context = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}