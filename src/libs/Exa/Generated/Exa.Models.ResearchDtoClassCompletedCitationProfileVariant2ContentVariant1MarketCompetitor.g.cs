
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_score")]
        public double? SimilarityScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employees")]
        public double? Employees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitorRevenue? Revenue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="website"></param>
        /// <param name="similarityScore"></param>
        /// <param name="employees"></param>
        /// <param name="revenue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor(
            string name,
            string? website,
            double? similarityScore,
            double? employees,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitorRevenue? revenue)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Website = website;
            this.SimilarityScore = similarityScore;
            this.Employees = employees;
            this.Revenue = revenue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1MarketCompetitor()
        {
        }

    }
}