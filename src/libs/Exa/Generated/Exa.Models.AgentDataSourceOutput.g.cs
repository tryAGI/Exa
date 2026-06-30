
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDataSourceOutput
    {
        /// <summary>
        /// Exa Connect data provider to enable for the run. All provider tools are available by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.AgentDataSourceProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AgentDataSourceProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDataSourceOutput" /> class.
        /// </summary>
        /// <param name="provider">
        /// Exa Connect data provider to enable for the run. All provider tools are available by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDataSourceOutput(
            global::Exa.AgentDataSourceProvider provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDataSourceOutput" /> class.
        /// </summary>
        public AgentDataSourceOutput()
        {
        }

    }
}