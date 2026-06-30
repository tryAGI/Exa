#nullable enable

namespace Exa
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const webhooks = await exa.websets.webhooks.list();<br/>
        /// console.log(`Found ${webhooks.data.length} webhooks`);<br/>
        /// webhooks.data.forEach((webhook) =&gt; {<br/>
        ///   console.log(`- ${webhook.id}: ${webhook.url}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ListWebhooksResponse> WebhooksListAsync(
            string? cursor = default,
            double? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const webhooks = await exa.websets.webhooks.list();<br/>
        /// console.log(`Found ${webhooks.data.length} webhooks`);<br/>
        /// webhooks.data.forEach((webhook) =&gt; {<br/>
        ///   console.log(`- ${webhook.id}: ${webhook.url}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListWebhooksResponse>> WebhooksListAsResponseAsync(
            string? cursor = default,
            double? limit = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}