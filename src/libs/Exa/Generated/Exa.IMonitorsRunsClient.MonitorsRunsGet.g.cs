#nullable enable

namespace Exa
{
    public partial interface IMonitorsRunsClient
    {
        /// <summary>
        /// Get Monitor Run<br/>
        /// Gets a specific monitor run.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const run = await exa.websets.monitors.runs.get("monitor_id", "run_id");<br/>
        /// console.log(`Monitor run: ${run.id} - ${run.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.MonitorRun> MonitorsRunsGetAsync(
            string monitor,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Monitor Run<br/>
        /// Gets a specific monitor run.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const run = await exa.websets.monitors.runs.get("monitor_id", "run_id");<br/>
        /// console.log(`Monitor run: ${run.id} - ${run.status}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.MonitorRun>> MonitorsRunsGetAsResponseAsync(
            string monitor,
            string id,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}