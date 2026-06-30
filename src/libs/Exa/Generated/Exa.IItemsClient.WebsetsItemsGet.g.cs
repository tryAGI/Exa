#nullable enable

namespace Exa
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// Get an Item<br/>
        /// Returns a Webset Item.
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
        /// const item = await exa.websets.items.get("webset_id", "item_id");<br/>
        /// console.log(`Item: ${item.id} - ${item.properties.name}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.WebsetItem> WebsetsItemsGetAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an Item<br/>
        /// Returns a Webset Item.
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
        /// const item = await exa.websets.items.get("webset_id", "item_id");<br/>
        /// console.log(`Item: ${item.id} - ${item.properties.name}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.WebsetItem>> WebsetsItemsGetAsResponseAsync(
            string webset,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}