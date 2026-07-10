#nullable enable

namespace Exa
{
    public partial interface IWebhooksAttemptsClient
    {
        /// <summary>
        /// List webhook attempts<br/>
        /// List all attempts made by a Webhook ordered in descending order.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="successful"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const attempts = await exa.websets.webhooks.listAttempts("webhook_id", {<br/>
        ///   limit: 20,<br/>
        /// });<br/>
        /// console.log(`Found ${attempts.data.length} webhook attempts`);<br/>
        /// attempts.data.forEach((attempt) =&gt; {<br/>
        ///   console.log(`- ${attempt.id}: ${attempt.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ListWebhookAttemptsResponse> WebhooksAttemptsListAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Exa.WebhooksAttemptsListEventType? eventType = default,
            bool? successful = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook attempts<br/>
        /// List all attempts made by a Webhook ordered in descending order.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="successful"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const attempts = await exa.websets.webhooks.listAttempts("webhook_id", {<br/>
        ///   limit: 20,<br/>
        /// });<br/>
        /// console.log(`Found ${attempts.data.length} webhook attempts`);<br/>
        /// attempts.data.forEach((attempt) =&gt; {<br/>
        ///   console.log(`- ${attempt.id}: ${attempt.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListWebhookAttemptsResponse>> WebhooksAttemptsListAsResponseAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::Exa.WebhooksAttemptsListEventType? eventType = default,
            bool? successful = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}