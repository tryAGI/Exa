
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant3ContentCertification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certification_name")]
        public string? CertificationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution_name")]
        public string? InstitutionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public string? Expiration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3ContentCertification" /> class.
        /// </summary>
        /// <param name="certificationName"></param>
        /// <param name="institutionName"></param>
        /// <param name="credentialId"></param>
        /// <param name="time"></param>
        /// <param name="expiration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant3ContentCertification(
            string? certificationName,
            string? institutionName,
            string? credentialId,
            string? time,
            string? expiration)
        {
            this.CertificationName = certificationName;
            this.InstitutionName = institutionName;
            this.CredentialId = credentialId;
            this.Time = time;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3ContentCertification" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant3ContentCertification()
        {
        }

    }
}