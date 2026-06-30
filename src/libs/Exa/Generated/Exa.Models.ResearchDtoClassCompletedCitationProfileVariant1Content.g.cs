
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant1Content
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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slogan")]
        public string? Slogan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about_us")]
        public string? AboutUs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("founded_year")]
        public double? FoundedYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funding")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentFunding? Funding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employees_num")]
        public double? EmployeesNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_num")]
        public double? FollowersNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_size")]
        public string? CompanySize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_type")]
        public string? CompanyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affiliated_companies")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentAffiliatedCompanie>? AffiliatedCompanies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        public string? Headquarters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentLocation>? Locations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialties")]
        public global::System.Collections.Generic.IList<string>? Specialties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crunchbase_url")]
        public string? CrunchbaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stock_symbol")]
        public string? StockSymbol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentMetaData MetaData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant1Content" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="metaData"></param>
        /// <param name="slogan"></param>
        /// <param name="aboutUs"></param>
        /// <param name="foundedYear"></param>
        /// <param name="funding"></param>
        /// <param name="website"></param>
        /// <param name="categories"></param>
        /// <param name="industry"></param>
        /// <param name="imageUrl"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="employeesNum"></param>
        /// <param name="followersNum"></param>
        /// <param name="companySize"></param>
        /// <param name="companyType"></param>
        /// <param name="affiliatedCompanies"></param>
        /// <param name="headquarters"></param>
        /// <param name="countryCode"></param>
        /// <param name="locations"></param>
        /// <param name="specialties"></param>
        /// <param name="crunchbaseUrl"></param>
        /// <param name="stockSymbol"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant1Content(
            string name,
            string url,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentMetaData metaData,
            string? slogan,
            string? aboutUs,
            double? foundedYear,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentFunding? funding,
            string? website,
            global::System.Collections.Generic.IList<string>? categories,
            string? industry,
            string? imageUrl,
            string? coverImageUrl,
            double? employeesNum,
            double? followersNum,
            string? companySize,
            string? companyType,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentAffiliatedCompanie>? affiliatedCompanies,
            string? headquarters,
            string? countryCode,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant1ContentLocation>? locations,
            global::System.Collections.Generic.IList<string>? specialties,
            string? crunchbaseUrl,
            string? stockSymbol)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Slogan = slogan;
            this.AboutUs = aboutUs;
            this.FoundedYear = foundedYear;
            this.Funding = funding;
            this.Website = website;
            this.Categories = categories;
            this.Industry = industry;
            this.ImageUrl = imageUrl;
            this.CoverImageUrl = coverImageUrl;
            this.EmployeesNum = employeesNum;
            this.FollowersNum = followersNum;
            this.CompanySize = companySize;
            this.CompanyType = companyType;
            this.AffiliatedCompanies = affiliatedCompanies;
            this.Headquarters = headquarters;
            this.CountryCode = countryCode;
            this.Locations = locations;
            this.Specialties = specialties;
            this.CrunchbaseUrl = crunchbaseUrl;
            this.StockSymbol = stockSymbol;
            this.MetaData = metaData ?? throw new global::System.ArgumentNullException(nameof(metaData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant1Content" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant1Content()
        {
        }

    }
}