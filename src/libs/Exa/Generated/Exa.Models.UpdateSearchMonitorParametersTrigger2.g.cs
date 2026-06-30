
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSearchMonitorParametersTrigger2
    {
        /// <summary>
        /// The type of trigger. Currently only `interval` is supported.<br/>
        /// Default Value: interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A duration string specifying how often the monitor runs (e.g., "1h", "6h", "1d", "7d"). Single-unit only. Minimum interval is 1 hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        public string? Period { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParametersTrigger2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of trigger. Currently only `interval` is supported.<br/>
        /// Default Value: interval
        /// </param>
        /// <param name="period">
        /// A duration string specifying how often the monitor runs (e.g., "1h", "6h", "1d", "7d"). Single-unit only. Minimum interval is 1 hour.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSearchMonitorParametersTrigger2(
            string? type,
            string? period)
        {
            this.Type = type;
            this.Period = period;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParametersTrigger2" /> class.
        /// </summary>
        public UpdateSearchMonitorParametersTrigger2()
        {
        }

    }
}