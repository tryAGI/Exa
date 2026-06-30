
#nullable enable

namespace Exa
{
    /// <summary>
    /// Accepted for compatibility and currently ignored.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CreateAgentRunRequestBudget
    {
        /// <summary>
        /// Accepted for compatibility and currently ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCostDollars")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? MaxCostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequestBudget" /> class.
        /// </summary>
        /// <param name="maxCostDollars">
        /// Accepted for compatibility and currently ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRunRequestBudget(
            double? maxCostDollars)
        {
            this.MaxCostDollars = maxCostDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequestBudget" /> class.
        /// </summary>
        public CreateAgentRunRequestBudget()
        {
        }

    }
}