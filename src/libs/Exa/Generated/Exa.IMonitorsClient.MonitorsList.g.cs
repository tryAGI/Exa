#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// List Monitors<br/>
        /// Lists all monitors for the Webset.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="websetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitors = await exa.websets.monitors.list({<br/>
        ///   webset_id: "webset_id",<br/>
        /// });<br/>
        /// console.log(`Found ${monitors.data.length} monitors`);<br/>
        /// monitors.data.forEach((monitor) =&gt; {<br/>
        ///   console.log(`- ${monitor.id}: ${monitor.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ListMonitorsResponse> MonitorsListAsync(
            string? cursor = default,
            double? limit = default,
            string? websetId = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Monitors<br/>
        /// Lists all monitors for the Webset.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="websetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitors = await exa.websets.monitors.list({<br/>
        ///   webset_id: "webset_id",<br/>
        /// });<br/>
        /// console.log(`Found ${monitors.data.length} monitors`);<br/>
        /// monitors.data.forEach((monitor) =&gt; {<br/>
        ///   console.log(`- ${monitor.id}: ${monitor.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListMonitorsResponse>> MonitorsListAsResponseAsync(
            string? cursor = default,
            double? limit = default,
            string? websetId = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}