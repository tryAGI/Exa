
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatusJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_of_priority")]
        public double? OrderOfPriority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="status"></param>
        /// <param name="orderOfPriority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail(
            string? email,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmailStatus? status,
            double? orderOfPriority)
        {
            this.Email = email;
            this.Status = status;
            this.OrderOfPriority = orderOfPriority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentContactEmail()
        {
        }

    }
}