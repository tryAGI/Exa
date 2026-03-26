
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Company financial information.
    /// </summary>
    public sealed partial class EntityCompanyPropertiesFinancials
    {
        /// <summary>
        /// Annual revenue in USD.<br/>
        /// Example: 1000000000
        /// </summary>
        /// <example>1000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenueAnnual")]
        public int? RevenueAnnual { get; set; }

        /// <summary>
        /// Total funding raised in USD.<br/>
        /// Example: 500000000
        /// </summary>
        /// <example>500000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fundingTotal")]
        public int? FundingTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fundingLatestRound")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.EntityCompanyPropertiesFundingRound, object>))]
        public global::Exa.OneOf<global::Exa.EntityCompanyPropertiesFundingRound, object>? FundingLatestRound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesFinancials" /> class.
        /// </summary>
        /// <param name="revenueAnnual">
        /// Annual revenue in USD.<br/>
        /// Example: 1000000000
        /// </param>
        /// <param name="fundingTotal">
        /// Total funding raised in USD.<br/>
        /// Example: 500000000
        /// </param>
        /// <param name="fundingLatestRound"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntityCompanyPropertiesFinancials(
            int? revenueAnnual,
            int? fundingTotal,
            global::Exa.OneOf<global::Exa.EntityCompanyPropertiesFundingRound, object>? fundingLatestRound)
        {
            this.RevenueAnnual = revenueAnnual;
            this.FundingTotal = fundingTotal;
            this.FundingLatestRound = fundingLatestRound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesFinancials" /> class.
        /// </summary>
        public EntityCompanyPropertiesFinancials()
        {
        }
    }
}