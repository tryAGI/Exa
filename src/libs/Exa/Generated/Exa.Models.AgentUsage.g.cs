
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentComputeUnits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgentComputeUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Searches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PhoneNumbers { get; set; }

        /// <summary>
        /// Per-provider tool call counts for Exa Connect data sources used during the run. Keys are provider names (e.g. `fiber`, `similarweb`). Only providers with non-zero usage are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSources")]
        public global::System.Collections.Generic.Dictionary<string, int>? DataSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUsage" /> class.
        /// </summary>
        /// <param name="agentComputeUnits"></param>
        /// <param name="searches"></param>
        /// <param name="emails"></param>
        /// <param name="phoneNumbers"></param>
        /// <param name="dataSources">
        /// Per-provider tool call counts for Exa Connect data sources used during the run. Keys are provider names (e.g. `fiber`, `similarweb`). Only providers with non-zero usage are included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUsage(
            double agentComputeUnits,
            int searches,
            int emails,
            int phoneNumbers,
            global::System.Collections.Generic.Dictionary<string, int>? dataSources)
        {
            this.AgentComputeUnits = agentComputeUnits;
            this.Searches = searches;
            this.Emails = emails;
            this.PhoneNumbers = phoneNumbers;
            this.DataSources = dataSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUsage" /> class.
        /// </summary>
        public AgentUsage()
        {
        }

    }
}