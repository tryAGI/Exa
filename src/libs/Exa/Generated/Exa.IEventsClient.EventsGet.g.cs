#nullable enable

namespace Exa
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get an Event<br/>
        /// Get a single Event by id.<br/>
        /// You can subscribe to Events by creating a Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const event = await exa.websets.events.get("event_id");<br/>
        /// console.log(`Event: ${event.id} - ${event.type}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.Event> EventsGetAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an Event<br/>
        /// Get a single Event by id.<br/>
        /// You can subscribe to Events by creating a Webhook.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const event = await exa.websets.events.get("event_id");<br/>
        /// console.log(`Event: ${event.id} - ${event.type}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Event>> EventsGetAsResponseAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}