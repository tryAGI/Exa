
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchMonitorsResponse
    {
        /// <summary>
        /// The action that was performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.BatchMonitorsResponseActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.BatchMonitorsResponseAction Action { get; set; }

        /// <summary>
        /// The number of monitors affected by the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Affected { get; set; }

        /// <summary>
        /// The IDs of the monitors that were affected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Whether this was a dry run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DryRun { get; set; }

        /// <summary>
        /// Whether there are more monitors matching the filter. If `true`, repeat the request to process the next batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMonitorsResponse" /> class.
        /// </summary>
        /// <param name="action">
        /// The action that was performed
        /// </param>
        /// <param name="affected">
        /// The number of monitors affected by the action
        /// </param>
        /// <param name="ids">
        /// The IDs of the monitors that were affected
        /// </param>
        /// <param name="dryRun">
        /// Whether this was a dry run
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more monitors matching the filter. If `true`, repeat the request to process the next batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchMonitorsResponse(
            global::Exa.BatchMonitorsResponseAction action,
            int affected,
            global::System.Collections.Generic.IList<string> ids,
            bool dryRun,
            bool hasMore)
        {
            this.Action = action;
            this.Affected = affected;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.DryRun = dryRun;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMonitorsResponse" /> class.
        /// </summary>
        public BatchMonitorsResponse()
        {
        }

    }
}