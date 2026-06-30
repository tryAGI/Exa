
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visits_monthly")]
        public double? VisitsMonthly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_visitors")]
        public double? UniqueVisitors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_rank")]
        public double? GlobalRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_rank")]
        public double? CountryRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_rank")]
        public double? CategoryRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounce_rate")]
        public double? BounceRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_per_visit")]
        public double? PagesPerVisit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_duration_seconds")]
        public double? AvgDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traffic_sources")]
        public global::System.Collections.Generic.Dictionary<string, double>? TrafficSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geo_distribution")]
        public global::System.Collections.Generic.Dictionary<string, double>? GeoDistribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_distribution")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution? AgeDistribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender_distribution")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficGenderDistribution? GenderDistribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similar_websites")]
        public global::System.Collections.Generic.IList<string>? SimilarWebsites { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_keywords")]
        public global::System.Collections.Generic.IList<string>? TopKeywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("growth")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficGrowth? Growth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficHistoryItem>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic" /> class.
        /// </summary>
        /// <param name="visitsMonthly"></param>
        /// <param name="uniqueVisitors"></param>
        /// <param name="globalRank"></param>
        /// <param name="countryRank"></param>
        /// <param name="categoryRank"></param>
        /// <param name="bounceRate"></param>
        /// <param name="pagesPerVisit"></param>
        /// <param name="avgDurationSeconds"></param>
        /// <param name="trafficSources"></param>
        /// <param name="geoDistribution"></param>
        /// <param name="ageDistribution"></param>
        /// <param name="genderDistribution"></param>
        /// <param name="similarWebsites"></param>
        /// <param name="topKeywords"></param>
        /// <param name="growth"></param>
        /// <param name="history"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic(
            double? visitsMonthly,
            double? uniqueVisitors,
            double? globalRank,
            double? countryRank,
            double? categoryRank,
            double? bounceRate,
            double? pagesPerVisit,
            double? avgDurationSeconds,
            global::System.Collections.Generic.Dictionary<string, double>? trafficSources,
            global::System.Collections.Generic.Dictionary<string, double>? geoDistribution,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution? ageDistribution,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficGenderDistribution? genderDistribution,
            global::System.Collections.Generic.IList<string>? similarWebsites,
            global::System.Collections.Generic.IList<string>? topKeywords,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficGrowth? growth,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficHistoryItem>? history)
        {
            this.VisitsMonthly = visitsMonthly;
            this.UniqueVisitors = uniqueVisitors;
            this.GlobalRank = globalRank;
            this.CountryRank = countryRank;
            this.CategoryRank = categoryRank;
            this.BounceRate = bounceRate;
            this.PagesPerVisit = pagesPerVisit;
            this.AvgDurationSeconds = avgDurationSeconds;
            this.TrafficSources = trafficSources;
            this.GeoDistribution = geoDistribution;
            this.AgeDistribution = ageDistribution;
            this.GenderDistribution = genderDistribution;
            this.SimilarWebsites = similarWebsites;
            this.TopKeywords = topKeywords;
            this.Growth = growth;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic()
        {
        }

    }
}