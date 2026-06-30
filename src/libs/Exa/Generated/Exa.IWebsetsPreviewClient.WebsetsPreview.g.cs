#nullable enable

namespace Exa
{
    public partial interface IWebsetsPreviewClient
    {
        /// <summary>
        /// Preview a webset<br/>
        /// Preview how a search query will be decomposed before creating a webset. This endpoint performs the same query analysis that happens during webset creation, allowing you to see the detected entity type, generated search criteria, and available enrichment columns in advance.<br/>
        /// Use this to help users understand how their search will be interpreted before committing to a full webset creation.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const preview = await exa.websets.preview({<br/>
        ///   search: {<br/>
        ///     query:<br/>
        ///       "Marketing agencies based in the US, that focus on consumer products. Get brands worked with and city",<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log("Search criteria:", preview.search.criteria);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.PreviewWebsetResponse> WebsetsPreviewAsync(
            bool? search,

            global::Exa.PreviewWebsetParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview a webset<br/>
        /// Preview how a search query will be decomposed before creating a webset. This endpoint performs the same query analysis that happens during webset creation, allowing you to see the detected entity type, generated search criteria, and available enrichment columns in advance.<br/>
        /// Use this to help users understand how their search will be interpreted before committing to a full webset creation.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const preview = await exa.websets.preview({<br/>
        ///   search: {<br/>
        ///     query:<br/>
        ///       "Marketing agencies based in the US, that focus on consumer products. Get brands worked with and city",<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log("Search criteria:", preview.search.criteria);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.PreviewWebsetResponse>> WebsetsPreviewAsResponseAsync(
            bool? search,

            global::Exa.PreviewWebsetParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview a webset<br/>
        /// Preview how a search query will be decomposed before creating a webset. This endpoint performs the same query analysis that happens during webset creation, allowing you to see the detected entity type, generated search criteria, and available enrichment columns in advance.<br/>
        /// Use this to help users understand how their search will be interpreted before committing to a full webset creation.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="requestSearch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.PreviewWebsetResponse> WebsetsPreviewAsync(
            bool? search,
            global::Exa.PreviewWebsetParametersSearch requestSearch,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}