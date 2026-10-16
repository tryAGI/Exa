
#nullable enable

namespace Exa
{
    /// <summary>
    /// The user's country only. Equivalent to the string form.
    /// </summary>
    public sealed partial class AnswerRequestUserLocationVariant1Variant2
    {
        /// <summary>
        /// The two-letter ISO 3166-1 country code of the user, e.g. `US`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequestUserLocationVariant1Variant2" /> class.
        /// </summary>
        /// <param name="country">
        /// The two-letter ISO 3166-1 country code of the user, e.g. `US`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerRequestUserLocationVariant1Variant2(
            string country)
        {
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequestUserLocationVariant1Variant2" /> class.
        /// </summary>
        public AnswerRequestUserLocationVariant1Variant2()
        {
        }

    }
}