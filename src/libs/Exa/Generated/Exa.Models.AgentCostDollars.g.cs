
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCostDollars
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentCompute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgentCompute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PhoneNumbers { get; set; }

        /// <summary>
        /// Per-provider cost in dollars for Exa Connect data sources used during the run. Keys are provider names (e.g. `fiber`, `similarweb`). Only providers with non-zero usage are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSources")]
        public global::System.Collections.Generic.Dictionary<string, double>? DataSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCostDollars" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="agentCompute"></param>
        /// <param name="search"></param>
        /// <param name="emails"></param>
        /// <param name="phoneNumbers"></param>
        /// <param name="dataSources">
        /// Per-provider cost in dollars for Exa Connect data sources used during the run. Keys are provider names (e.g. `fiber`, `similarweb`). Only providers with non-zero usage are included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCostDollars(
            double total,
            double agentCompute,
            double search,
            double emails,
            double phoneNumbers,
            global::System.Collections.Generic.Dictionary<string, double>? dataSources)
        {
            this.Total = total;
            this.AgentCompute = agentCompute;
            this.Search = search;
            this.Emails = emails;
            this.PhoneNumbers = phoneNumbers;
            this.DataSources = dataSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCostDollars" /> class.
        /// </summary>
        public AgentCostDollars()
        {
        }

    }
}