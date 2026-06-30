
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetSearchCriteriaItem
    {
        /// <summary>
        /// The description of the criterion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Value between 0 and 100 representing the percentage of results that meet the criterion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SuccessRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchCriteriaItem" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the criterion
        /// </param>
        /// <param name="successRate">
        /// Value between 0 and 100 representing the percentage of results that meet the criterion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetSearchCriteriaItem(
            string description,
            double successRate)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.SuccessRate = successRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchCriteriaItem" /> class.
        /// </summary>
        public WebsetSearchCriteriaItem()
        {
        }

    }
}