
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentCertification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        public string? IssuerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate_url")]
        public string? CertificateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_from")]
        public global::System.DateTime? DateFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_to")]
        public global::System.DateTime? DateTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_in_profile")]
        public double? OrderInProfile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentCertification" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="issuer"></param>
        /// <param name="issuerUrl"></param>
        /// <param name="credentialId"></param>
        /// <param name="certificateUrl"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="orderInProfile"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentCertification(
            string? title,
            string? issuer,
            string? issuerUrl,
            string? credentialId,
            string? certificateUrl,
            global::System.DateTime? dateFrom,
            global::System.DateTime? dateTo,
            double? orderInProfile)
        {
            this.Title = title;
            this.Issuer = issuer;
            this.IssuerUrl = issuerUrl;
            this.CredentialId = credentialId;
            this.CertificateUrl = certificateUrl;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.OrderInProfile = orderInProfile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentCertification" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentCertification()
        {
        }

    }
}