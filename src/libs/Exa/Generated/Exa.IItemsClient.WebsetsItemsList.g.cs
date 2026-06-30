#nullable enable

namespace Exa
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// List all Items for a Webset<br/>
        /// Returns a list of Webset Items.<br/>
        /// You can paginate through the Items using the `cursor` parameter.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const items = await exa.websets.items.list("webset_id", {<br/>
        ///   limit: 20,<br/>
        /// });<br/>
        /// console.log(`Found ${items.data.length} items`);<br/>
        /// items.data.forEach((item) =&gt; {<br/>
        ///   console.log(`- ${item.id}: ${item.properties.name}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ListWebsetItemResponse> WebsetsItemsListAsync(
            string webset,
            string? cursor = default,
            double? limit = default,
            string? sourceId = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all Items for a Webset<br/>
        /// Returns a list of Webset Items.<br/>
        /// You can paginate through the Items using the `cursor` parameter.
        /// </summary>
        /// <param name="webset"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="sourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const items = await exa.websets.items.list("webset_id", {<br/>
        ///   limit: 20,<br/>
        /// });<br/>
        /// console.log(`Found ${items.data.length} items`);<br/>
        /// items.data.forEach((item) =&gt; {<br/>
        ///   console.log(`- ${item.id}: ${item.properties.name}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListWebsetItemResponse>> WebsetsItemsListAsResponseAsync(
            string webset,
            string? cursor = default,
            double? limit = default,
            string? sourceId = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}