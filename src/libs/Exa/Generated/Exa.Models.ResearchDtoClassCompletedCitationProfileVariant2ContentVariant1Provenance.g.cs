
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrimarySource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collected_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CollectedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completeness")]
        public double? Completeness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public global::System.Collections.Generic.Dictionary<string, double>? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance" /> class.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="primarySource"></param>
        /// <param name="collectedAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="completeness"></param>
        /// <param name="confidence"></param>
        /// <param name="isVerified"></param>
        /// <param name="isActive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance(
            global::System.Collections.Generic.IList<string> sources,
            string primarySource,
            double collectedAt,
            double? updatedAt,
            double? completeness,
            global::System.Collections.Generic.Dictionary<string, double>? confidence,
            bool? isVerified,
            bool? isActive)
        {
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.PrimarySource = primarySource ?? throw new global::System.ArgumentNullException(nameof(primarySource));
            this.CollectedAt = collectedAt;
            this.UpdatedAt = updatedAt;
            this.Completeness = completeness;
            this.Confidence = confidence;
            this.IsVerified = isVerified;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Provenance()
        {
        }

    }
}