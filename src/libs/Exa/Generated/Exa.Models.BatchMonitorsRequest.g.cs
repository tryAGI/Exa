
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchMonitorsRequest
    {
        /// <summary>
        /// The action to perform on matching monitors. `delete` permanently removes them, `pause` sets their status to paused, and `unpause` sets their status to active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.BatchMonitorsRequestActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.BatchMonitorsRequestAction Action { get; set; }

        /// <summary>
        /// At least one filter field must be provided to prevent accidental bulk operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.BatchMonitorsRequestFilter Filter { get; set; }

        /// <summary>
        /// When `true`, returns the monitors that would be affected without performing the action. Defaults to `true`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Maximum number of monitors to process in a single request. Defaults to 50, maximum 500.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMonitorsRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// The action to perform on matching monitors. `delete` permanently removes them, `pause` sets their status to paused, and `unpause` sets their status to active.
        /// </param>
        /// <param name="filter">
        /// At least one filter field must be provided to prevent accidental bulk operations.
        /// </param>
        /// <param name="dryRun">
        /// When `true`, returns the monitors that would be affected without performing the action. Defaults to `true`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Maximum number of monitors to process in a single request. Defaults to 50, maximum 500.<br/>
        /// Default Value: 50
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchMonitorsRequest(
            global::Exa.BatchMonitorsRequestAction action,
            global::Exa.BatchMonitorsRequestFilter filter,
            bool? dryRun,
            int? limit)
        {
            this.Action = action;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.DryRun = dryRun;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMonitorsRequest" /> class.
        /// </summary>
        public BatchMonitorsRequest()
        {
        }

    }
}