
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMonitorParameters
    {
        /// <summary>
        /// The id of the Webset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsetId { get; set; }

        /// <summary>
        /// How often the monitor will run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CreateMonitorParametersCadence Cadence { get; set; }

        /// <summary>
        /// Behavior to perform when monitor runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CreateMonitorParametersBehavior Behavior { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMonitorParameters" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMonitorParameters(
            string websetId,
            global::Exa.CreateMonitorParametersCadence cadence,
            global::Exa.CreateMonitorParametersBehavior behavior,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.WebsetId = websetId ?? throw new global::System.ArgumentNullException(nameof(websetId));
            this.Cadence = cadence ?? throw new global::System.ArgumentNullException(nameof(cadence));
            this.Behavior = behavior ?? throw new global::System.ArgumentNullException(nameof(behavior));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMonitorParameters" /> class.
        /// </summary>
        public CreateMonitorParameters()
        {
        }

    }
}