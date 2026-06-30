
#nullable enable

namespace Exa
{
    /// <summary>
    /// How often the monitor will run
    /// </summary>
    public sealed partial class MonitorCadence
    {
        /// <summary>
        /// Cron expression for monitor cadence (must be a valid Unix cron with 5 fields). The schedule must trigger at most once per day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cron { get; set; }

        /// <summary>
        /// IANA timezone (e.g., "America/New_York")<br/>
        /// Default Value: Etc/UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorCadence" /> class.
        /// </summary>
        /// <param name="cron">
        /// Cron expression for monitor cadence (must be a valid Unix cron with 5 fields). The schedule must trigger at most once per day.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone (e.g., "America/New_York")<br/>
        /// Default Value: Etc/UTC
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorCadence(
            string cron,
            string? timezone)
        {
            this.Cron = cron ?? throw new global::System.ArgumentNullException(nameof(cron));
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorCadence" /> class.
        /// </summary>
        public MonitorCadence()
        {
        }

    }
}