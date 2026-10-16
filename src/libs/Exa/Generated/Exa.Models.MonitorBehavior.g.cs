
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MonitorBehavior
    {
        /// <summary>
        /// Search parameters for each Monitor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorBehaviorConfig Config { get; set; }

        /// <summary>
        /// Configure the Monitor to find new Items matching your search criteria<br/>
        /// Default Value: search
        /// </summary>
        /// <default>"search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "search";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBehavior" /> class.
        /// </summary>
        /// <param name="config">
        /// Search parameters for each Monitor run.
        /// </param>
        /// <param name="type">
        /// Configure the Monitor to find new Items matching your search criteria<br/>
        /// Default Value: search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorBehavior(
            global::Exa.MonitorBehaviorConfig config,
            string type = "search")
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBehavior" /> class.
        /// </summary>
        public MonitorBehavior()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MonitorBehavior"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MonitorBehavior FromConfig(global::Exa.MonitorBehaviorConfig config)
        {
            return new MonitorBehavior
            {
                Config = config,
            };
        }

    }
}