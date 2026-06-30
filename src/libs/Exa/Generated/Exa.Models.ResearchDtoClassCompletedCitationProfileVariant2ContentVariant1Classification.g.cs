
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("industries")]
        public global::System.Collections.Generic.IList<string>? Industries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sic_codes")]
        public global::System.Collections.Generic.IList<string>? SicCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naics_codes")]
        public global::System.Collections.Generic.IList<string>? NaicsCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_b2b")]
        public bool? IsB2b { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_type")]
        public string? CompanyType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification" /> class.
        /// </summary>
        /// <param name="industry"></param>
        /// <param name="industries"></param>
        /// <param name="categories"></param>
        /// <param name="keywords"></param>
        /// <param name="sicCodes"></param>
        /// <param name="naicsCodes"></param>
        /// <param name="isB2b"></param>
        /// <param name="isPublic"></param>
        /// <param name="companyType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification(
            string? industry,
            global::System.Collections.Generic.IList<string>? industries,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.Collections.Generic.IList<string>? keywords,
            global::System.Collections.Generic.IList<string>? sicCodes,
            global::System.Collections.Generic.IList<string>? naicsCodes,
            bool? isB2b,
            bool? isPublic,
            string? companyType)
        {
            this.Industry = industry;
            this.Industries = industries;
            this.Categories = categories;
            this.Keywords = keywords;
            this.SicCodes = sicCodes;
            this.NaicsCodes = naicsCodes;
            this.IsB2b = isB2b;
            this.IsPublic = isPublic;
            this.CompanyType = companyType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification()
        {
        }

    }
}