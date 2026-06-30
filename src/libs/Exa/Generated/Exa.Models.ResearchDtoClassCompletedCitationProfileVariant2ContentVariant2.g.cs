
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2
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
        public string? LinkedinUrl { get; set; }

        /// <summary>
        /// Default Value: 1-reduced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2VersionJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Identity Identity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Classification? Classification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basics")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Basics? Basics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations? Locations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Profiles? Profiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workforce")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce? Workforce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financials")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials? Financials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_traffic")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2WebTraffic? WebTraffic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("news_activity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivityJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity? NewsActivity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Metadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="identity"></param>
        /// <param name="linkedinUrl"></param>
        /// <param name="version">
        /// Default Value: 1-reduced
        /// </param>
        /// <param name="classification"></param>
        /// <param name="basics"></param>
        /// <param name="locations"></param>
        /// <param name="profiles"></param>
        /// <param name="workforce"></param>
        /// <param name="financials"></param>
        /// <param name="webTraffic"></param>
        /// <param name="newsActivity"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2(
            string url,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Identity identity,
            string? linkedinUrl,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Version? version,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Classification? classification,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Basics? basics,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations? locations,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Profiles? profiles,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce? workforce,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials? financials,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2WebTraffic? webTraffic,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2NewsActivity? newsActivity,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Metadata? metadata)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.LinkedinUrl = linkedinUrl;
            this.Version = version;
            this.Identity = identity ?? throw new global::System.ArgumentNullException(nameof(identity));
            this.Classification = classification;
            this.Basics = basics;
            this.Locations = locations;
            this.Profiles = profiles;
            this.Workforce = workforce;
            this.Financials = financials;
            this.WebTraffic = webTraffic;
            this.NewsActivity = newsActivity;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2()
        {
        }

    }
}