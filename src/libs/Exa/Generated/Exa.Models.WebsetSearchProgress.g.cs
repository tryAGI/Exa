
#nullable enable

namespace Exa
{
    /// <summary>
    /// The progress of the search
    /// </summary>
    public sealed partial class WebsetSearchProgress
    {
        /// <summary>
        /// The number of results found so far
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("found")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Found { get; set; }

        /// <summary>
        /// The number of results analyzed so far
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Analyzed { get; set; }

        /// <summary>
        /// The completion percentage of the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Completion { get; set; }

        /// <summary>
        /// The estimated time remaining in seconds, null if unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeLeft")]
        public double? TimeLeft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchProgress" /> class.
        /// </summary>
        /// <param name="found">
        /// The number of results found so far
        /// </param>
        /// <param name="analyzed">
        /// The number of results analyzed so far
        /// </param>
        /// <param name="completion">
        /// The completion percentage of the search
        /// </param>
        /// <param name="timeLeft">
        /// The estimated time remaining in seconds, null if unknown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetSearchProgress(
            double found,
            double analyzed,
            double completion,
            double? timeLeft)
        {
            this.Found = found;
            this.Analyzed = analyzed;
            this.Completion = completion;
            this.TimeLeft = timeLeft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchProgress" /> class.
        /// </summary>
        public WebsetSearchProgress()
        {
        }

    }
}