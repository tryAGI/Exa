
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public double? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count_inferred")]
        public double? TotalCountInferred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_range")]
        public string? SizeRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        public string? DataSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_department")]
        public global::System.Collections.Generic.Dictionary<string, double>? ByDepartment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_seniority")]
        public global::System.Collections.Generic.Dictionary<string, double>? BySeniority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_location")]
        public global::System.Collections.Generic.Dictionary<string, double>? ByLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_country")]
        public global::System.Collections.Generic.Dictionary<string, double>? ByCountry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_seniority_monthly")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceBySeniorityMonthlyItem>? BySeniorityMonthly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_department_monthly")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByDepartmentMonthlyItem>? ByDepartmentMonthly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_region_monthly")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByRegionMonthlyItem>? ByRegionMonthly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_country_monthly")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByCountryMonthlyItem>? ByCountryMonthly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executives")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceExecutive>? Executives { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_hires")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentHire>? RecentHires { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_departures")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentDeparture>? RecentDepartures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_previous_companies")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopPreviousCompanie>? TopPreviousCompanies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_next_companies")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopNextCompanie>? TopNextCompanies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_job_postings_count")]
        public double? ActiveJobPostingsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_job_postings")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPosting>? ActiveJobPostings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_job_postings_history")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsHistoryItem>? ActiveJobPostingsHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_job_postings_growth")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsGrowth? ActiveJobPostingsGrowth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salary_ranges")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceSalaryRange>? SalaryRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("growth")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceGrowth? Growth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceHistoryItem>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="totalCountInferred"></param>
        /// <param name="sizeRange"></param>
        /// <param name="dataSource"></param>
        /// <param name="byDepartment"></param>
        /// <param name="bySeniority"></param>
        /// <param name="byLocation"></param>
        /// <param name="byCountry"></param>
        /// <param name="bySeniorityMonthly"></param>
        /// <param name="byDepartmentMonthly"></param>
        /// <param name="byRegionMonthly"></param>
        /// <param name="byCountryMonthly"></param>
        /// <param name="executives"></param>
        /// <param name="recentHires"></param>
        /// <param name="recentDepartures"></param>
        /// <param name="topPreviousCompanies"></param>
        /// <param name="topNextCompanies"></param>
        /// <param name="activeJobPostingsCount"></param>
        /// <param name="activeJobPostings"></param>
        /// <param name="activeJobPostingsHistory"></param>
        /// <param name="activeJobPostingsGrowth"></param>
        /// <param name="salaryRanges"></param>
        /// <param name="growth"></param>
        /// <param name="history"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce(
            double? totalCount,
            double? totalCountInferred,
            string? sizeRange,
            string? dataSource,
            global::System.Collections.Generic.Dictionary<string, double>? byDepartment,
            global::System.Collections.Generic.Dictionary<string, double>? bySeniority,
            global::System.Collections.Generic.Dictionary<string, double>? byLocation,
            global::System.Collections.Generic.Dictionary<string, double>? byCountry,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceBySeniorityMonthlyItem>? bySeniorityMonthly,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByDepartmentMonthlyItem>? byDepartmentMonthly,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByRegionMonthlyItem>? byRegionMonthly,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceByCountryMonthlyItem>? byCountryMonthly,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceExecutive>? executives,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentHire>? recentHires,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceRecentDeparture>? recentDepartures,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopPreviousCompanie>? topPreviousCompanies,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceTopNextCompanie>? topNextCompanies,
            double? activeJobPostingsCount,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPosting>? activeJobPostings,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsHistoryItem>? activeJobPostingsHistory,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceActiveJobPostingsGrowth? activeJobPostingsGrowth,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceSalaryRange>? salaryRanges,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceGrowth? growth,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WorkforceHistoryItem>? history)
        {
            this.TotalCount = totalCount;
            this.TotalCountInferred = totalCountInferred;
            this.SizeRange = sizeRange;
            this.DataSource = dataSource;
            this.ByDepartment = byDepartment;
            this.BySeniority = bySeniority;
            this.ByLocation = byLocation;
            this.ByCountry = byCountry;
            this.BySeniorityMonthly = bySeniorityMonthly;
            this.ByDepartmentMonthly = byDepartmentMonthly;
            this.ByRegionMonthly = byRegionMonthly;
            this.ByCountryMonthly = byCountryMonthly;
            this.Executives = executives;
            this.RecentHires = recentHires;
            this.RecentDepartures = recentDepartures;
            this.TopPreviousCompanies = topPreviousCompanies;
            this.TopNextCompanies = topNextCompanies;
            this.ActiveJobPostingsCount = activeJobPostingsCount;
            this.ActiveJobPostings = activeJobPostings;
            this.ActiveJobPostingsHistory = activeJobPostingsHistory;
            this.ActiveJobPostingsGrowth = activeJobPostingsGrowth;
            this.SalaryRanges = salaryRanges;
            this.Growth = growth;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce()
        {
        }

    }
}