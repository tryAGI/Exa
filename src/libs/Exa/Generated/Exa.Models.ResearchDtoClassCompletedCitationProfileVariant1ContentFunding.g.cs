
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant1ContentFunding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_rounds")]
        public string? NumberOfRounds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public string? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_round_date")]
        public string? LastRoundDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_round_stage")]
        public string? LastRoundStage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant1ContentFunding" /> class.
        /// </summary>
        /// <param name="numberOfRounds"></param>
        /// <param name="price"></param>
        /// <param name="lastRoundDate"></param>
        /// <param name="lastRoundStage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant1ContentFunding(
            string? numberOfRounds,
            string? price,
            string? lastRoundDate,
            string? lastRoundStage)
        {
            this.NumberOfRounds = numberOfRounds;
            this.Price = price;
            this.LastRoundDate = lastRoundDate;
            this.LastRoundStage = lastRoundStage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant1ContentFunding" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant1ContentFunding()
        {
        }

    }
}