
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_aliases")]
        public global::System.Collections.Generic.IList<string>? WebsiteAliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesSocialItem>? Social { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crunchbase_url")]
        public string? CrunchbaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bloomberg_url")]
        public string? BloombergUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitchbook_url")]
        public string? PitchbookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glassdoor_url")]
        public string? GlassdoorUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indeed_url")]
        public string? IndeedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_base64")]
        public string? LogoBase64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesContact? Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate>? Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles" /> class.
        /// </summary>
        /// <param name="website"></param>
        /// <param name="websiteAliases"></param>
        /// <param name="social"></param>
        /// <param name="crunchbaseUrl"></param>
        /// <param name="bloombergUrl"></param>
        /// <param name="pitchbookUrl"></param>
        /// <param name="glassdoorUrl"></param>
        /// <param name="indeedUrl"></param>
        /// <param name="logoUrl"></param>
        /// <param name="logoBase64"></param>
        /// <param name="contact"></param>
        /// <param name="updates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles(
            string? website,
            global::System.Collections.Generic.IList<string>? websiteAliases,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesSocialItem>? social,
            string? crunchbaseUrl,
            string? bloombergUrl,
            string? pitchbookUrl,
            string? glassdoorUrl,
            string? indeedUrl,
            string? logoUrl,
            string? logoBase64,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesContact? contact,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate>? updates)
        {
            this.Website = website;
            this.WebsiteAliases = websiteAliases;
            this.Social = social;
            this.CrunchbaseUrl = crunchbaseUrl;
            this.BloombergUrl = bloombergUrl;
            this.PitchbookUrl = pitchbookUrl;
            this.GlassdoorUrl = glassdoorUrl;
            this.IndeedUrl = indeedUrl;
            this.LogoUrl = logoUrl;
            this.LogoBase64 = logoBase64;
            this.Contact = contact;
            this.Updates = updates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Profiles()
        {
        }

    }
}