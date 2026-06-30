
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProduct>? Products { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_free_trial")]
        public bool? HasFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_free_plan")]
        public bool? HasFreePlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_demo")]
        public bool? HasDemo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_api")]
        public bool? HasApi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_mobile_app")]
        public bool? HasMobileApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_available")]
        public bool? PricingAvailable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tech_stack")]
        public global::System.Collections.Generic.IList<string>? TechStack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("technologies")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsTechnologie>? Technologies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tech_categories")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? TechCategories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products" /> class.
        /// </summary>
        /// <param name="products"></param>
        /// <param name="hasFreeTrial"></param>
        /// <param name="hasFreePlan"></param>
        /// <param name="hasDemo"></param>
        /// <param name="hasApi"></param>
        /// <param name="hasMobileApp"></param>
        /// <param name="pricingAvailable"></param>
        /// <param name="techStack"></param>
        /// <param name="technologies"></param>
        /// <param name="techCategories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products(
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsProduct>? products,
            bool? hasFreeTrial,
            bool? hasFreePlan,
            bool? hasDemo,
            bool? hasApi,
            bool? hasMobileApp,
            bool? pricingAvailable,
            global::System.Collections.Generic.IList<string>? techStack,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProductsTechnologie>? technologies,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? techCategories)
        {
            this.Products = products;
            this.HasFreeTrial = hasFreeTrial;
            this.HasFreePlan = hasFreePlan;
            this.HasDemo = hasDemo;
            this.HasApi = hasApi;
            this.HasMobileApp = hasMobileApp;
            this.PricingAvailable = pricingAvailable;
            this.TechStack = techStack;
            this.Technologies = technologies;
            this.TechCategories = techCategories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Products()
        {
        }

    }
}