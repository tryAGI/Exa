
#nullable enable

namespace Exa
{
    /// <summary>
    /// Web traffic metrics for the company
    /// </summary>
    public sealed partial class WebsetItemCompanyPropertiesCompanyWebTraffic
    {
        /// <summary>
        /// The estimated monthly website visits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitsMonthly")]
        public double? VisitsMonthly { get; set; }

        /// <summary>
        /// The estimated monthly unique visitors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueVisitors")]
        public double? UniqueVisitors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyWebTraffic" /> class.
        /// </summary>
        /// <param name="visitsMonthly">
        /// The estimated monthly website visits
        /// </param>
        /// <param name="uniqueVisitors">
        /// The estimated monthly unique visitors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemCompanyPropertiesCompanyWebTraffic(
            double? visitsMonthly,
            double? uniqueVisitors)
        {
            this.VisitsMonthly = visitsMonthly;
            this.UniqueVisitors = uniqueVisitors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyWebTraffic" /> class.
        /// </summary>
        public WebsetItemCompanyPropertiesCompanyWebTraffic()
        {
        }

    }
}