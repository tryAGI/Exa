
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorBehavior2
    {
        /// <summary>
        /// Default Value: search
        /// </summary>
        /// <default>"search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "search";

        /// <summary>
        /// Specify the search parameters for the Monitor.<br/>
        /// By default, the search parameters (query, entity and criteria) from the last search are used when no parameters are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorBehaviorConfig2 Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBehavior2" /> class.
        /// </summary>
        /// <param name="config">
        /// Specify the search parameters for the Monitor.<br/>
        /// By default, the search parameters (query, entity and criteria) from the last search are used when no parameters are provided.
        /// </param>
        /// <param name="type">
        /// Default Value: search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorBehavior2(
            global::Exa.MonitorBehaviorConfig2 config,
            string type = "search")
        {
            this.Type = type;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorBehavior2" /> class.
        /// </summary>
        public MonitorBehavior2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MonitorBehavior2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MonitorBehavior2 FromConfig(global::Exa.MonitorBehaviorConfig2 config)
        {
            return new MonitorBehavior2
            {
                Config = config,
            };
        }

    }
}