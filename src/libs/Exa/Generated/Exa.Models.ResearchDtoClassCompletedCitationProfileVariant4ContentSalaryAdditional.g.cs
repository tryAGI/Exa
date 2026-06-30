
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        public string? Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="period"></param>
        /// <param name="currency"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional(
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem>? items,
            string? period,
            string? currency,
            global::System.DateTime? updatedAt)
        {
            this.Items = items;
            this.Period = period;
            this.Currency = currency;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional()
        {
        }

    }
}