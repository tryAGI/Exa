#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Get Monitor<br/>
        /// Gets a specific monitor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitor = await exa.websets.monitors.get("monitor_id");<br/>
        /// console.log(`Monitor: ${monitor.id} - ${monitor.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.Monitor> MonitorsGetAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Monitor<br/>
        /// Gets a specific monitor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitor = await exa.websets.monitors.get("monitor_id");<br/>
        /// console.log(`Monitor: ${monitor.id} - ${monitor.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Monitor>> MonitorsGetAsResponseAsync(
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}