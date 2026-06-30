#nullable enable

namespace Exa
{
    public partial interface IWebsetsClient
    {
        /// <summary>
        /// Get a Webset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const webset = await exa.websets.get("webset_id");<br/>
        /// console.log(`Webset: ${webset.id} - ${webset.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.GetWebsetResponse> WebsetsGetAsync(
            string id,
            global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>? expand = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Webset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const webset = await exa.websets.get("webset_id");<br/>
        /// console.log(`Webset: ${webset.id} - ${webset.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.GetWebsetResponse>> WebsetsGetAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::Exa.WebsetsGetExpandItem>? expand = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}