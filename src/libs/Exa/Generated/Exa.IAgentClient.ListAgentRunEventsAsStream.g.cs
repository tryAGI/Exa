#nullable enable

namespace Exa
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// List run events<br/>
        /// List stored events for an Agent run. Set `Accept: text/event-stream` to replay stored events as server-sent events. Use `cursor` for JSON pagination or `Last-Event-ID` for SSE replay.
        /// </summary>
        /// <param name="id">
        /// Agent run ID.
        /// </param>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination. Use the `nextCursor` value from the previous event list response.
        /// </param>
        /// <param name="accept">
        /// Set to `text/event-stream` to receive server-sent events.
        /// </param>
        /// <param name="lastEventId">
        /// For SSE replay, return only events after this event ID.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://api.exa.ai/agent/runs/&lt;id&gt;/events \<br/>
        ///   -H "x-api-key: $EXA_API_KEY"
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::Exa.AgentRunEvent> ListAgentRunEventsAsStreamAsync(
            string id,
            int? limit = default,
            string? cursor = default,
            global::Exa.ListAgentRunEventsAccept? accept = default,
            string? lastEventId = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}