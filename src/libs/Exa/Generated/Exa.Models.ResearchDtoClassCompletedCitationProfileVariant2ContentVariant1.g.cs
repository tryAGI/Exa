
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedin_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LinkedinUrl { get; set; }

        /// <summary>
        /// Default Value: 1-complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1VersionJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Identity Identity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification? Classification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Locations? Locations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles? Profiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provenance")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance? Provenance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basics")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics? Basics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workforce")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce? Workforce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financials")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials? Financials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("market")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Market? Market { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products? Products { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customers")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers? Customers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_traffic")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic? WebTraffic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("news_activity")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivity? NewsActivity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xverum")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum? Xverum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="linkedinUrl"></param>
        /// <param name="identity"></param>
        /// <param name="version">
        /// Default Value: 1-complete
        /// </param>
        /// <param name="classification"></param>
        /// <param name="locations"></param>
        /// <param name="profiles"></param>
        /// <param name="provenance"></param>
        /// <param name="basics"></param>
        /// <param name="workforce"></param>
        /// <param name="financials"></param>
        /// <param name="market"></param>
        /// <param name="products"></param>
        /// <param name="customers"></param>
        /// <param name="webTraffic"></param>
        /// <param name="newsActivity"></param>
        /// <param name="xverum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1(
            string url,
            string linkedinUrl,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Identity identity,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Version? version,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Classification? classification,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Locations? locations,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles? profiles,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance? provenance,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics? basics,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Workforce? workforce,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials? financials,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Market? market,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products? products,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers? customers,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTraffic? webTraffic,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1NewsActivity? newsActivity,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum? xverum)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.LinkedinUrl = linkedinUrl ?? throw new global::System.ArgumentNullException(nameof(linkedinUrl));
            this.Version = version;
            this.Identity = identity ?? throw new global::System.ArgumentNullException(nameof(identity));
            this.Classification = classification;
            this.Locations = locations;
            this.Profiles = profiles;
            this.Provenance = provenance;
            this.Basics = basics;
            this.Workforce = workforce;
            this.Financials = financials;
            this.Market = market;
            this.Products = products;
            this.Customers = customers;
            this.WebTraffic = webTraffic;
            this.NewsActivity = newsActivity;
            this.Xverum = xverum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1()
        {
        }

    }
}