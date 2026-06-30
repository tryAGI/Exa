#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Create a Monitor<br/>
        /// Creates a new `Monitor` to continuously keep your Websets updated with fresh data.<br/>
        /// Monitors automatically run on your defined schedule to ensure your Websets stay current without manual intervention:<br/>
        /// - **Find new content**: Execute `search` operations to discover fresh items matching your criteria<br/>
        /// - **Update existing content**: Run `refresh` operations to update items contents and enrichments<br/>
        /// - **Automated scheduling**: Configure `cron` expressions and `timezone` for precise scheduling control
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitor = await exa.websets.monitors.create({<br/>
        ///   websetId: "webset_id",<br/>
        ///   cadence: {<br/>
        ///     cron: "0 9 * * 1", // Every Monday at 9 AM<br/>
        ///     timezone: "America/New_York",<br/>
        ///   },<br/>
        ///   behavior: {<br/>
        ///     type: "search",<br/>
        ///     config: {<br/>
        ///       behavior: "append",<br/>
        ///       query: "new companies to monitor",<br/>
        ///       count: 10,<br/>
        ///     },<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(`Created monitor: ${monitor.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.Monitor> MonitorsCreateAsync(

            global::Exa.CreateMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Monitor<br/>
        /// Creates a new `Monitor` to continuously keep your Websets updated with fresh data.<br/>
        /// Monitors automatically run on your defined schedule to ensure your Websets stay current without manual intervention:<br/>
        /// - **Find new content**: Execute `search` operations to discover fresh items matching your criteria<br/>
        /// - **Update existing content**: Run `refresh` operations to update items contents and enrichments<br/>
        /// - **Automated scheduling**: Configure `cron` expressions and `timezone` for precise scheduling control
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        /// <remarks>
        /// // npm install exa-js<br/>
        /// import Exa from "exa-js";<br/>
        /// const exa = new Exa("YOUR_EXA_API_KEY");<br/>
        /// const monitor = await exa.websets.monitors.create({<br/>
        ///   websetId: "webset_id",<br/>
        ///   cadence: {<br/>
        ///     cron: "0 9 * * 1", // Every Monday at 9 AM<br/>
        ///     timezone: "America/New_York",<br/>
        ///   },<br/>
        ///   behavior: {<br/>
        ///     type: "search",<br/>
        ///     config: {<br/>
        ///       behavior: "append",<br/>
        ///       query: "new companies to monitor",<br/>
        ///       count: 10,<br/>
        ///     },<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(`Created monitor: ${monitor.id}`);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Monitor>> MonitorsCreateAsResponseAsync(

            global::Exa.CreateMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Monitor<br/>
        /// Creates a new `Monitor` to continuously keep your Websets updated with fresh data.<br/>
        /// Monitors automatically run on your defined schedule to ensure your Websets stay current without manual intervention:<br/>
        /// - **Find new content**: Execute `search` operations to discover fresh items matching your criteria<br/>
        /// - **Update existing content**: Run `refresh` operations to update items contents and enrichments<br/>
        /// - **Automated scheduling**: Configure `cron` expressions and `timezone` for precise scheduling control
        /// </summary>
        /// <param name="websetId">
        /// The id of the Webset
        /// </param>
        /// <param name="cadence">
        /// How often the monitor will run
        /// </param>
        /// <param name="behavior">
        /// Behavior to perform when monitor runs
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Monitor> MonitorsCreateAsync(
            string websetId,
            global::Exa.CreateMonitorParametersCadence cadence,
            global::Exa.CreateMonitorParametersBehavior behavior,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}