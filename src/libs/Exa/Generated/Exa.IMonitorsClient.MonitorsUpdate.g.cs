#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Update Monitor<br/>
        /// Updates a monitor configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitor = await exa.websets.monitors.update("monitor_id", {<br/>
        ///   cadence: {<br/>
        ///     cron: "0 14 * * *", // Every day at 2 PM<br/>
        ///     timezone: "America/New_York",<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(`Updated monitor: ${monitor.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.Monitor> MonitorsUpdateAsync(
            string id,

            global::Exa.UpdateMonitor request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Monitor<br/>
        /// Updates a monitor configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitor = await exa.websets.monitors.update("monitor_id", {<br/>
        ///   cadence: {<br/>
        ///     cron: "0 14 * * *", // Every day at 2 PM<br/>
        ///     timezone: "America/New_York",<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(`Updated monitor: ${monitor.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Monitor>> MonitorsUpdateAsResponseAsync(
            string id,

            global::Exa.UpdateMonitor request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Monitor<br/>
        /// Updates a monitor configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the monitor.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cadence"></param>
        /// <param name="behavior"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Monitor> MonitorsUpdateAsync(
            string id,
            global::Exa.UpdateMonitorStatus? status = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.MonitorCadence2? cadence = default,
            global::Exa.MonitorBehavior2? behavior = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}