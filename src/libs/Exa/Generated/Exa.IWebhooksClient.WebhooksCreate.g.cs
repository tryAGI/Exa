#nullable enable

namespace Exa
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create a Webhook
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const webhook = await exa.websets.webhooks.create({<br/>
        ///   url: "https://api.yourapp.com/webhooks/exa",<br/>
        ///   events: ["webset.completed", "enrichment.completed"],<br/>
        /// });<br/>
        /// console.log(`Created webhook: ${webhook.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.Webhook> WebhooksCreateAsync(

            global::Exa.CreateWebhookParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webhook
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const webhook = await exa.websets.webhooks.create({<br/>
        ///   url: "https://api.yourapp.com/webhooks/exa",<br/>
        ///   events: ["webset.completed", "enrichment.completed"],<br/>
        /// });<br/>
        /// console.log(`Created webhook: ${webhook.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Webhook>> WebhooksCreateAsResponseAsync(

            global::Exa.CreateWebhookParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webhook
        /// </summary>
        /// <param name="events">
        /// The events to trigger the webhook
        /// </param>
        /// <param name="url">
        /// The URL to send the webhook to
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Webhook> WebhooksCreateAsync(
            global::System.Collections.Generic.IList<global::Exa.EventType> events,
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}