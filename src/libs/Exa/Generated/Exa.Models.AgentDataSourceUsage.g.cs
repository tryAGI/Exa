
#nullable enable

namespace Exa
{
    /// <summary>
    /// Per-provider tool call counts for Exa Connect data sources used during the run. Keys are provider names (e.g. `fiber`, `similarweb`). Only providers with non-zero usage are included.
    /// </summary>
    public sealed partial class AgentDataSourceUsage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}