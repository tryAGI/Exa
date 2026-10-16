#nullable enable

namespace Exa
{
    public partial interface ISearchesClient
    {
        /// <summary>
        /// Create a Search<br/>
        /// Creates a new Search for the Webset.<br/>
        /// The default behavior is to reuse the previous Search results and evaluate them against the new criteria.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.WebsetSearch> WebsetsSearchesCreateAsync(
            string webset,

            global::Exa.CreateWebsetSearchParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Search<br/>
        /// Creates a new Search for the Webset.<br/>
        /// The default behavior is to reuse the previous Search results and evaluate them against the new criteria.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetSearch>> WebsetsSearchesCreateAsResponseAsync(
            string webset,

            global::Exa.CreateWebsetSearchParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Search<br/>
        /// Creates a new Search for the Webset.<br/>
        /// The default behavior is to reuse the previous Search results and evaluate them against the new criteria.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="count">
        /// Number of Items the Search will attempt to find.<br/>
        /// The actual number of Items found may be less than this number depending on the query complexity.
        /// </param>
        /// <param name="query">
        /// Natural language search query describing what you are looking for.<br/>
        /// Be specific and descriptive about your requirements, characteristics, and any constraints that help narrow down the results.<br/>
        /// Any URLs provided will be crawled and used as additional context for the search.
        /// </param>
        /// <param name="entity">
        /// Entity the search returns results for. Detected from the query when omitted.
        /// </param>
        /// <param name="criteria">
        /// Criteria every Item is evaluated against. Generated from the query when omitted.
        /// </param>
        /// <param name="maxPeoplePerCompany">
        /// Optional soft cap for people searches. When set, the search will try to include at most this many matching people from the same current employer company.
        /// </param>
        /// <param name="exclude">
        /// Imports or Websets whose items are left out of this search's results.
        /// </param>
        /// <param name="scope">
        /// Limit the search to specific sources (existing imports). Any results found within these sources matching the search criteria will be included in the Webset.
        /// </param>
        /// <param name="recall">
        /// Whether to estimate how many relevant results exist for this search. The estimate is returned in the search's `recall` field.
        /// </param>
        /// <param name="behavior">
        /// How this search interacts with existing items in the Webset:<br/>
        /// - **override**: Replace existing items and evaluate all items against new criteria<br/>
        /// - **append**: Add new items to existing ones, keeping items that match the new criteria<br/>
        /// Default Value: override
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.WebsetSearch> WebsetsSearchesCreateAsync(
            string webset,
            double count,
            string query,
            global::Exa.Entity? entity = default,
            global::System.Collections.Generic.IList<global::Exa.CreateCriterionParameters>? criteria = default,
            int? maxPeoplePerCompany = default,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersExcludeItem>? exclude = default,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetSearchParametersScopeItem>? scope = default,
            bool? recall = default,
            global::Exa.WebsetSearchBehavior? behavior = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}