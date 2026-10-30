#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Create a Monitor<br/>
        /// To run a recurring Exa search and send new results to your webhook, use the [Monitors API](https://exa.ai/docs/reference/monitors/create-a-monitor). This endpoint creates a Monitor that searches for new Items for a Webset on a `cron` schedule in the given `timezone`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.Monitor> MonitorsCreateAsync(

            global::Exa.CreateMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Monitor<br/>
        /// To run a recurring Exa search and send new results to your webhook, use the [Monitors API](https://exa.ai/docs/reference/monitors/create-a-monitor). This endpoint creates a Monitor that searches for new Items for a Webset on a `cron` schedule in the given `timezone`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.Monitor>> MonitorsCreateAsResponseAsync(

            global::Exa.CreateMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Monitor<br/>
        /// To run a recurring Exa search and send new results to your webhook, use the [Monitors API](https://exa.ai/docs/reference/monitors/create-a-monitor). This endpoint creates a Monitor that searches for new Items for a Webset on a `cron` schedule in the given `timezone`.
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
            global::Exa.MonitorCadence cadence,
            global::Exa.MonitorBehavior behavior,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}