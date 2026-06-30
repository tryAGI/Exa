
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_18_24")]
        public double? Age1824 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_25_34")]
        public double? Age2534 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_35_44")]
        public double? Age3544 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_45_54")]
        public double? Age4554 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_55_64")]
        public double? Age5564 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_65_plus")]
        public double? Age65Plus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution" /> class.
        /// </summary>
        /// <param name="age1824"></param>
        /// <param name="age2534"></param>
        /// <param name="age3544"></param>
        /// <param name="age4554"></param>
        /// <param name="age5564"></param>
        /// <param name="age65Plus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution(
            double? age1824,
            double? age2534,
            double? age3544,
            double? age4554,
            double? age5564,
            double? age65Plus)
        {
            this.Age1824 = age1824;
            this.Age2534 = age2534;
            this.Age3544 = age3544;
            this.Age4554 = age4554;
            this.Age5564 = age5564;
            this.Age65Plus = age65Plus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1WebTrafficAgeDistribution()
        {
        }

    }
}