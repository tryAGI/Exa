
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetSearchRecallExpected
    {
        /// <summary>
        /// The estimated total number of potential matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// The confidence in the estimate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetSearchRecallExpectedConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetSearchRecallExpectedConfidence Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetSearchRecallExpectedBounds Bounds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchRecallExpected" /> class.
        /// </summary>
        /// <param name="total">
        /// The estimated total number of potential matches
        /// </param>
        /// <param name="confidence">
        /// The confidence in the estimate
        /// </param>
        /// <param name="bounds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetSearchRecallExpected(
            double total,
            global::Exa.WebsetSearchRecallExpectedConfidence confidence,
            global::Exa.WebsetSearchRecallExpectedBounds bounds)
        {
            this.Total = total;
            this.Confidence = confidence;
            this.Bounds = bounds ?? throw new global::System.ArgumentNullException(nameof(bounds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchRecallExpected" /> class.
        /// </summary>
        public WebsetSearchRecallExpected()
        {
        }

    }
}