
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemCompanyPropertiesCompany
    {
        /// <summary>
        /// The name of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The main location of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The number of employees of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employees")]
        public double? Employees { get; set; }

        /// <summary>
        /// The industry of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// A short description of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about")]
        public string? About { get; set; }

        /// <summary>
        /// The logo URL of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logoUrl")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// The year the company was founded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foundedYear")]
        public double? FoundedYear { get; set; }

        /// <summary>
        /// The structured headquarters address of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        public global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters? Headquarters { get; set; }

        /// <summary>
        /// Financial information about the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financials")]
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancials? Financials { get; set; }

        /// <summary>
        /// Web traffic metrics for the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webTraffic")]
        public global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic? WebTraffic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompany" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the company
        /// </param>
        /// <param name="location">
        /// The main location of the company
        /// </param>
        /// <param name="employees">
        /// The number of employees of the company
        /// </param>
        /// <param name="industry">
        /// The industry of the company
        /// </param>
        /// <param name="about">
        /// A short description of the company
        /// </param>
        /// <param name="logoUrl">
        /// The logo URL of the company
        /// </param>
        /// <param name="foundedYear">
        /// The year the company was founded
        /// </param>
        /// <param name="headquarters">
        /// The structured headquarters address of the company
        /// </param>
        /// <param name="financials">
        /// Financial information about the company
        /// </param>
        /// <param name="webTraffic">
        /// Web traffic metrics for the company
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemCompanyPropertiesCompany(
            string name,
            string? location,
            double? employees,
            string? industry,
            string? about,
            string? logoUrl,
            double? foundedYear,
            global::Exa.WebsetItemCompanyPropertiesCompanyHeadquarters? headquarters,
            global::Exa.WebsetItemCompanyPropertiesCompanyFinancials? financials,
            global::Exa.WebsetItemCompanyPropertiesCompanyWebTraffic? webTraffic)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Location = location;
            this.Employees = employees;
            this.Industry = industry;
            this.About = about;
            this.LogoUrl = logoUrl;
            this.FoundedYear = foundedYear;
            this.Headquarters = headquarters;
            this.Financials = financials;
            this.WebTraffic = webTraffic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompany" /> class.
        /// </summary>
        public WebsetItemCompanyPropertiesCompany()
        {
        }

    }
}