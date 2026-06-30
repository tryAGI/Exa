
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetSearchRecallExpectedBounds
    {
        /// <summary>
        /// The minimum estimated total number of potential matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        /// The maximum estimated total number of potential matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchRecallExpectedBounds" /> class.
        /// </summary>
        /// <param name="min">
        /// The minimum estimated total number of potential matches
        /// </param>
        /// <param name="max">
        /// The maximum estimated total number of potential matches
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetSearchRecallExpectedBounds(
            double min,
            double max)
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchRecallExpectedBounds" /> class.
        /// </summary>
        public WebsetSearchRecallExpectedBounds()
        {
        }

    }
}