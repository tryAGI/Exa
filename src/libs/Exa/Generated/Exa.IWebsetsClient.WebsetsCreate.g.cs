#nullable enable

namespace Exa
{
    public partial interface IWebsetsClient
    {
        /// <summary>
        /// Create a Webset<br/>
        /// Creates a new Webset with optional search, import, and enrichment configurations. The Webset will automatically begin processing once created.<br/>
        /// You can specify an `externalId` to reference the Webset with your own identifiers for easier integration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from 'exa-js';<br/>
        /// const exa = new Exa('YOUR_EXA_API_KEY');<br/>
        /// const webset = await exa.websets.create({<br/>
        ///   search: {<br/>
        ///     query: "Tech companies in San Francisco",<br/>
        ///     count: 10<br/>
        ///   }<br/>
        /// });<br/>
        /// console.log(`Created webset: ${webset.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.Webset> WebsetsCreateAsync(

            global::Exa.CreateWebsetParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webset<br/>
        /// Creates a new Webset with optional search, import, and enrichment configurations. The Webset will automatically begin processing once created.<br/>
        /// You can specify an `externalId` to reference the Webset with your own identifiers for easier integration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from 'exa-js';<br/>
        /// const exa = new Exa('YOUR_EXA_API_KEY');<br/>
        /// const webset = await exa.websets.create({<br/>
        ///   search: {<br/>
        ///     query: "Tech companies in San Francisco",<br/>
        ///     count: 10<br/>
        ///   }<br/>
        /// });<br/>
        /// console.log(`Created webset: ${webset.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Webset>> WebsetsCreateAsResponseAsync(

            global::Exa.CreateWebsetParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webset<br/>
        /// Creates a new Webset with optional search, import, and enrichment configurations. The Webset will automatically begin processing once created.<br/>
        /// You can specify an `externalId` to reference the Webset with your own identifiers for easier integration.
        /// </summary>
        /// <param name="title">
        /// Optional name that appears anywhere the Webset is displayed. Leave empty to have Exa generate one automatically.
        /// </param>
        /// <param name="search">
        /// Create initial search for the Webset.
        /// </param>
        /// <param name="import">
        /// Import data from existing Websets and Imports into this Webset.
        /// </param>
        /// <param name="enrichments">
        /// Add enrichments to extract additional data from found items.<br/>
        /// Enrichments automatically search for and extract specific information (like contact details, funding data, employee counts, etc.) from each item added to your Webset.
        /// </param>
        /// <param name="exclude">
        /// Global exclusion sources (existing imports or websets) that apply to all operations within this Webset. Any results found within these sources will be omitted across all search and import operations.
        /// </param>
        /// <param name="externalId">
        /// The external identifier for the webset.<br/>
        /// You can use this to reference the Webset by your own internal identifiers.
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Webset> WebsetsCreateAsync(
            string? title = default,
            global::Exa.CreateWebsetParametersSearch? search = default,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>? import = default,
            global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>? enrichments = default,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>? exclude = default,
            string? externalId = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}