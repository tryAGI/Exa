
#nullable enable

namespace Exa
{
    /// <summary>
    /// At least one filter field must be provided to prevent accidental bulk operations.
    /// </summary>
    public sealed partial class BatchMonitorsRequestFilter
    {
        /// <summary>
        /// Filter by name (case-insensitive substring match)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Filter by monitor status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.BatchMonitorsRequestFilterStatusJsonConverter))]
        public global::Exa.BatchMonitorsRequestFilterStatus? Status { get; set; }

        /// <summary>
        /// Filter by metadata key-value pairs (exact match, AND semantics)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMonitorsRequestFilter" /> class.
        /// </summary>
        /// <param name="name">
        /// Filter by name (case-insensitive substring match)
        /// </param>
        /// <param name="status">
        /// Filter by monitor status
        /// </param>
        /// <param name="metadata">
        /// Filter by metadata key-value pairs (exact match, AND semantics)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchMonitorsRequestFilter(
            string? name,
            global::Exa.BatchMonitorsRequestFilterStatus? status,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.Status = status;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMonitorsRequestFilter" /> class.
        /// </summary>
        public BatchMonitorsRequestFilter()
        {
        }

    }
}