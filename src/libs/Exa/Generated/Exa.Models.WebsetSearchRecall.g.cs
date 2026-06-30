
#nullable enable

namespace Exa
{
    /// <summary>
    /// Recall metrics for the search, null if not yet computed or requested.
    /// </summary>
    public sealed partial class WebsetSearchRecall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetSearchRecallExpected Expected { get; set; }

        /// <summary>
        /// The reasoning for the estimate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchRecall" /> class.
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="reasoning">
        /// The reasoning for the estimate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetSearchRecall(
            global::Exa.WebsetSearchRecallExpected expected,
            string reasoning)
        {
            this.Expected = expected ?? throw new global::System.ArgumentNullException(nameof(expected));
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchRecall" /> class.
        /// </summary>
        public WebsetSearchRecall()
        {
        }

    }
}