#nullable enable

namespace Exa
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// List all Events<br/>
        /// List all events that have occurred in the system.<br/>
        /// You can paginate through the results using the `cursor` parameter.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="types"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.ListEventsResponse> EventsListAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Exa.EventsListType>? types = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? createdAfter = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all Events<br/>
        /// List all events that have occurred in the system.<br/>
        /// You can paginate through the results using the `cursor` parameter.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="types"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListEventsResponse>> EventsListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Exa.EventsListType>? types = default,
            global::System.DateTime? createdBefore = default,
            global::System.DateTime? createdAfter = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}