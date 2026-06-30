
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerSearchMonitorResponse
    {
        /// <summary>
        /// Whether the monitor was successfully triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Triggered { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSearchMonitorResponse" /> class.
        /// </summary>
        /// <param name="triggered">
        /// Whether the monitor was successfully triggered
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerSearchMonitorResponse(
            bool triggered)
        {
            this.Triggered = triggered;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSearchMonitorResponse" /> class.
        /// </summary>
        public TriggerSearchMonitorResponse()
        {
        }

    }
}