
#nullable enable

namespace Exa
{
    /// <summary>
    /// Records to process and records or entities to exclude from the answer.
    /// </summary>
    public sealed partial class CreateAgentRunRequestInput
    {
        /// <summary>
        /// Records the agent should process or enrich.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? Data { get; set; }

        /// <summary>
        /// Records or entities the agent should avoid returning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusion")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? Exclusion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequestInput" /> class.
        /// </summary>
        /// <param name="data">
        /// Records the agent should process or enrich.
        /// </param>
        /// <param name="exclusion">
        /// Records or entities the agent should avoid returning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRunRequestInput(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? data,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? exclusion)
        {
            this.Data = data;
            this.Exclusion = exclusion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequestInput" /> class.
        /// </summary>
        public CreateAgentRunRequestInput()
        {
        }

    }
}