#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

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
        /// curl -X POST https://api.exa.ai/contents \<br/>
        ///   -H "x-api-key: $EXA_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///   "urls": [<br/>
        ///     "&lt;url&gt;"<br/>
        ///   ],<br/>
        ///   "highlights": true<br/>
        /// }'
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
        /// curl -X POST https://api.exa.ai/contents \<br/>
        ///   -H "x-api-key: $EXA_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///   "urls": [<br/>
        ///     "&lt;url&gt;"<br/>
        ///   ],<br/>
        ///   "highlights": true<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ContentsResponse>> GetContentsAsResponseAsync(

            global::Exa.ContentsRequest request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Contents
        /// </summary>
        /// <param name="ids">
        /// Document IDs obtained from searches.
        /// </param>
        /// <param name="urls">
        /// URLs to crawl (backwards compatible with the `ids` parameter).
        /// </param>
        /// <param name="compliance"></param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
        /// <param name="text"></param>
        /// <param name="highlights"></param>
        /// <param name="summary"></param>
        /// <param name="extras"></param>
        /// <param name="livecrawlTimeout"></param>
        /// <param name="maxAgeHours"></param>
        /// <param name="snapshotAsOf"></param>
        /// <param name="subpages"></param>
        /// <param name="subpageTarget"></param>
        /// <param name="context"></param>
        /// <param name="livecrawl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ContentsResponse> GetContentsAsync(
            global::System.Collections.Generic.IList<string>? ids = default,
            global::System.Collections.Generic.IList<string>? urls = default,
            global::Exa.ContentsRequestCompliance? compliance = default,
            string? userIdentifier = default,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>? text = default,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>? highlights = default,
            global::Exa.ContentsRequestSummary? summary = default,
            global::Exa.ContentsRequestExtras? extras = default,
            int? livecrawlTimeout = default,
            int? maxAgeHours = default,
            global::System.DateTime? snapshotAsOf = default,
            int? subpages = default,
            global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget = default,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>? context = default,
            global::Exa.ContentsRequestLivecrawl? livecrawl = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}