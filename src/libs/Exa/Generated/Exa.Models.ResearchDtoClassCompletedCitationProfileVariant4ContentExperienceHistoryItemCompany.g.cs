
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public double? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("founded_year")]
        public double? FoundedYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_count")]
        public double? FollowersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedin_url")]
        public string? LinkedinUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facebook_urls")]
        public global::System.Collections.Generic.IList<string>? FacebookUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_urls")]
        public global::System.Collections.Generic.IList<string>? TwitterUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_range")]
        public string? SizeRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employees_count")]
        public double? EmployeesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employees_count_change_yearly_percentage")]
        public double? EmployeesCountChangeYearlyPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories_and_keywords")]
        public global::System.Collections.Generic.IList<string>? CategoriesAndKeywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_source_1")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1? RevenueSource1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_source_5")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource5? RevenueSource5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_funding")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyLastFunding? LastFunding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyHeadquarters? Headquarters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stock_tickers")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyStockTicker>? StockTickers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_b2b")]
        public bool? IsB2b { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="foundedYear"></param>
        /// <param name="followersCount"></param>
        /// <param name="website"></param>
        /// <param name="linkedinUrl"></param>
        /// <param name="facebookUrls"></param>
        /// <param name="twitterUrls"></param>
        /// <param name="sizeRange"></param>
        /// <param name="employeesCount"></param>
        /// <param name="employeesCountChangeYearlyPercentage"></param>
        /// <param name="industry"></param>
        /// <param name="categoriesAndKeywords"></param>
        /// <param name="revenueSource1"></param>
        /// <param name="revenueSource5"></param>
        /// <param name="lastFunding"></param>
        /// <param name="headquarters"></param>
        /// <param name="stockTickers"></param>
        /// <param name="isB2b"></param>
        /// <param name="lastUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany(
            double? id,
            string? name,
            string? type,
            double? foundedYear,
            double? followersCount,
            string? website,
            string? linkedinUrl,
            global::System.Collections.Generic.IList<string>? facebookUrls,
            global::System.Collections.Generic.IList<string>? twitterUrls,
            string? sizeRange,
            double? employeesCount,
            double? employeesCountChangeYearlyPercentage,
            string? industry,
            global::System.Collections.Generic.IList<string>? categoriesAndKeywords,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1? revenueSource1,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource5? revenueSource5,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyLastFunding? lastFunding,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyHeadquarters? headquarters,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyStockTicker>? stockTickers,
            bool? isB2b,
            global::System.DateTime? lastUpdatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.FoundedYear = foundedYear;
            this.FollowersCount = followersCount;
            this.Website = website;
            this.LinkedinUrl = linkedinUrl;
            this.FacebookUrls = facebookUrls;
            this.TwitterUrls = twitterUrls;
            this.SizeRange = sizeRange;
            this.EmployeesCount = employeesCount;
            this.EmployeesCountChangeYearlyPercentage = employeesCountChangeYearlyPercentage;
            this.Industry = industry;
            this.CategoriesAndKeywords = categoriesAndKeywords;
            this.RevenueSource1 = revenueSource1;
            this.RevenueSource5 = revenueSource5;
            this.LastFunding = lastFunding;
            this.Headquarters = headquarters;
            this.StockTickers = stockTickers;
            this.IsB2b = isB2b;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany()
        {
        }

    }
}