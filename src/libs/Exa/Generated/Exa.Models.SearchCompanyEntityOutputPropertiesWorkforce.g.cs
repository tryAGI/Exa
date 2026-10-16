
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchCompanyEntityOutputPropertiesWorkforce
    {
        /// <summary>
        /// Total estimated employee count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCompanyEntityOutputPropertiesWorkforce" /> class.
        /// </summary>
        /// <param name="total">
        /// Total estimated employee count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCompanyEntityOutputPropertiesWorkforce(
            double? total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCompanyEntityOutputPropertiesWorkforce" /> class.
        /// </summary>
        public SearchCompanyEntityOutputPropertiesWorkforce()
        {
        }

    }
}