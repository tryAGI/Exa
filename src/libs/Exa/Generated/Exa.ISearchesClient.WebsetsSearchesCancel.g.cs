#nullable enable

namespace Exa
{
    public partial interface ISearchesClient
    {
        /// <summary>
        /// Cancel a running Search<br/>
        /// Cancels a currently running Search.<br/>
        /// You can cancel all searches at once by using the `websets/:webset/cancel` endpoint.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const search = await exa.websets.searches.cancel("webset_id", "search_id");<br/>
        /// console.log(`Cancelled search: ${search.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.WebsetSearch> WebsetsSearchesCancelAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a running Search<br/>
        /// Cancels a currently running Search.<br/>
        /// You can cancel all searches at once by using the `websets/:webset/cancel` endpoint.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const search = await exa.websets.searches.cancel("webset_id", "search_id");<br/>
        /// console.log(`Cancelled search: ${search.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetSearch>> WebsetsSearchesCancelAsResponseAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}