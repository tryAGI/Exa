
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMonitorTriggerOutput
    {
        /// <summary>
        /// The type of trigger. Currently only `interval` is supported.<br/>
        /// Default Value: interval
        /// </summary>
        /// <default>"interval"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "interval";

        /// <summary>
        /// A duration string specifying how often the monitor runs (e.g., "1h", "6h", "1d", "7d"). Single-unit only. Minimum interval is 1 hour. The schedule is anchored to the monitor's creation time (e.g., a daily monitor created at 2:30 PM runs daily around 2:30 PM).<br/>
        /// Example: 6h
        /// </summary>
        /// <example>6h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Period { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorTriggerOutput" /> class.
        /// </summary>
        /// <param name="period">
        /// A duration string specifying how often the monitor runs (e.g., "1h", "6h", "1d", "7d"). Single-unit only. Minimum interval is 1 hour. The schedule is anchored to the monitor's creation time (e.g., a daily monitor created at 2:30 PM runs daily around 2:30 PM).<br/>
        /// Example: 6h
        /// </param>
        /// <param name="type">
        /// The type of trigger. Currently only `interval` is supported.<br/>
        /// Default Value: interval
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorTriggerOutput(
            string period,
            string type = "interval")
        {
            this.Type = type;
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorTriggerOutput" /> class.
        /// </summary>
        public SearchMonitorTriggerOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SearchMonitorTriggerOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SearchMonitorTriggerOutput FromPeriod(string period)
        {
            return new SearchMonitorTriggerOutput
            {
                Period = period,
            };
        }

    }
}