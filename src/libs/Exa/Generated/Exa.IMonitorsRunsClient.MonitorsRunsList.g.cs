#nullable enable

namespace Exa
{
    public partial interface IMonitorsRunsClient
    {
        /// <summary>
        /// List Monitor Runs<br/>
        /// Lists all runs for the Monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const runs = await exa.websets.monitors.runs.list("monitor_id");<br/>
        /// console.log(`Found ${runs.data.length} monitor runs`);<br/>
        /// runs.data.forEach((run) =&gt; {<br/>
        ///   console.log(`- ${run.id}: ${run.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.ListMonitorRunsResponse> MonitorsRunsListAsync(
            string monitor,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Monitor Runs<br/>
        /// Lists all runs for the Monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const runs = await exa.websets.monitors.runs.list("monitor_id");<br/>
        /// console.log(`Found ${runs.data.length} monitor runs`);<br/>
        /// runs.data.forEach((run) =&gt; {<br/>
        ///   console.log(`- ${run.id}: ${run.status}`);<br/>
        /// });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.ListMonitorRunsResponse>> MonitorsRunsListAsResponseAsync(
            string monitor,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}