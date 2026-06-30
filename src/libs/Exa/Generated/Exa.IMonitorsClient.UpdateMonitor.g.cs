#nullable enable

namespace Exa
{
    public partial interface IMonitorsClient
    {
        /// <summary>
        /// Update a Monitor<br/>
        /// Updates an existing monitor. All fields are optional. For `search`, you can send a partial object containing only the fields you want to change. Set `trigger` to `null` to remove the schedule.
        /// </summary>
        /// <param name="id">
        /// The monitor ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.SearchMonitor> UpdateMonitorAsync(
            string id,

            global::Exa.UpdateSearchMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Monitor<br/>
        /// Updates an existing monitor. All fields are optional. For `search`, you can send a partial object containing only the fields you want to change. Set `trigger` to `null` to remove the schedule.
        /// </summary>
        /// <param name="id">
        /// The monitor ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Exa.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.AutoSDKHttpResponse<global::Exa.SearchMonitor>> UpdateMonitorAsResponseAsync(
            string id,

            global::Exa.UpdateSearchMonitorParameters request,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Monitor<br/>
        /// Updates an existing monitor. All fields are optional. For `search`, you can send a partial object containing only the fields you want to change. Set `trigger` to `null` to remove the schedule.
        /// </summary>
        /// <param name="id">
        /// The monitor ID
        /// </param>
        /// <param name="name">
        /// Update the monitor name
        /// </param>
        /// <param name="status">
        /// Update the monitor status (can only set to `active` or `paused`)
        /// </param>
        /// <param name="search">
        /// Partial search params to merge. All fields are optional for updates.
        /// </param>
        /// <param name="trigger">
        /// Update the schedule. Set to null to remove the schedule.
        /// </param>
        /// <param name="outputSchema">
        /// Controls the format of the run output. Defaults to `{ "type": "text" }` if not specified. When `type` is `"text"`, the output is a plain text summary. When `type` is `"object"`, the output is structured JSON. If no `properties` are specified with `"object"` type, a schema is inferred automatically; otherwise the output adheres to the provided schema.
        /// </param>
        /// <param name="metadata">
        /// Update metadata. Set to null to remove. Echoed back in webhook deliveries so you can route updates to systems like Slack.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </param>
        /// <param name="webhook">
        /// Partial webhook params to merge. All fields are optional for updates.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Exa.SearchMonitor> UpdateMonitorAsync(
            string id,
            string? name = default,
            global::Exa.UpdateSearchMonitorParametersStatus? status = default,
            global::Exa.UpdateSearchMonitorParametersSearch? search = default,
            global::Exa.UpdateSearchMonitorParametersTrigger2? trigger = default,
            global::Exa.OneOf<global::Exa.SearchMonitorOutputSchemaVariant1Variant1, global::Exa.SearchMonitorOutputSchemaVariant1Variant2>? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Exa.UpdateSearchMonitorParametersWebhook? webhook = default,
            global::Exa.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}