
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentContact
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_email")]
        public string? PrimaryEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_email_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus? PrimaryEmailStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail>? Emails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentContact" /> class.
        /// </summary>
        /// <param name="primaryEmail"></param>
        /// <param name="primaryEmailStatus"></param>
        /// <param name="emails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentContact(
            string? primaryEmail,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus? primaryEmailStatus,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail>? emails)
        {
            this.PrimaryEmail = primaryEmail;
            this.PrimaryEmailStatus = primaryEmailStatus;
            this.Emails = emails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentContact" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentContact()
        {
        }

    }
}