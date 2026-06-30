#nullable enable

namespace Exa
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// Delete an Item<br/>
        /// Deletes an Item from the Webset.<br/>
        /// This will cancel any enrichment process for it.
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
        /// await exa.websets.items.delete("webset_id", "item_id");<br/>
        /// console.log("Item deleted successfully");
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.WebsetItem> WebsetsItemsDeleteAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an Item<br/>
        /// Deletes an Item from the Webset.<br/>
        /// This will cancel any enrichment process for it.
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
        /// await exa.websets.items.delete("webset_id", "item_id");<br/>
        /// console.log("Item deleted successfully");
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetItem>> WebsetsItemsDeleteAsResponseAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}